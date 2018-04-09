/**
  ******************************************************************************
  * @date    
  * @authors Sergey Vasiliev
  * @brief   Ported from ActionScript 3.0
  ******************************************************************************
    
  ПОЛУЧИТЬ РЕАЛЬНОЕ ВРЕМЯ ВЫЗОВА, ТАКИМ СПОСОБОМ НЕЛЬЗЯ.
  ТОЛЬКО ПРИБЛИЗИТЕЛЬНОЕ ЗНАЧЕНИЕ.
  
    var p1:int = Profiler.start("one");
        var p2:int = Profiler.start("two");
            var p3:int = Profiler.start("three");
                call_function()
            Profiler.end(p3);
        Profiler.end(p2);
    Profiler.end(p1);

  	OUTPUT
        [PROFILER]  three 1 ms
        [PROFILER]  two 3 ms
        [PROFILER]  one 3 ms
*/

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace l420
{
    public class profiler
    {
        static Dictionary<int,_probe> _probes   = new Dictionary<int,_probe>();
        static int          _count_probe   = 0;
        
        #region Singleton - пример шаблона
        static private profiler _instance = null;
        static public profiler get
        {
            get
            {
                if(_instance == null)
                    _instance = new profiler();
                return _instance;
            }
        }

        private profiler()
        {
            //constructor
        }

        #endregion

        ////
        ///
        //
        static public int start(string tag = "", int pid = 0)
        {
            pid = (pid == 0) ? (++_count_probe) : pid;
            var probe = new _probe( tag );
            
            probe.tag   = tag;
            probe.memory= Process.GetCurrentProcess().PrivateMemorySize64;

            probe.watch.Reset();
            probe.watch.Start();

            _probes [pid] = probe;

            return pid;
        }
        ////
        ///
        //
        static public void stop(int pid = 0)
        {
            if(pid > 0 && _probes.Count > 0) //fix double stop exec
            {
                var probe       = _probes[ pid ];

                probe.watch.Stop(); // << stop watch

                var _temp_mem   = Process.GetCurrentProcess().PrivateMemorySize64;
                var malloc      = Math.Round( (_temp_mem - probe.memory)  / 1024F );

                _probes.Remove( pid );

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                log.print
                (
                    ""
                    + "@"+ probe.tag + ""
                    + " time: "     + probe.watch.ElapsedMilliseconds + " ms"
                    + " malloc: "   + ((malloc > 0) ? "+" : "") + malloc + " kb"
                );
                Console.ResetColor();
            }
            //else Debug.INFO( "id датчика не указан" )

        }
    }//class end

    public class _probe
    {
        public string   tag;
        public long     time;
        public long     memory;
        public Stopwatch watch;

        public _probe(string tag)
        {
            this.tag = tag;
            this.watch = new Stopwatch();
        }
    }
}
