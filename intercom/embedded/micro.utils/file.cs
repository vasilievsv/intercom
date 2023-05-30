/**
  ******************************************************************************
  * @date   
  * @version 
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace utils
{
	public static class file 
	{
        static public string Read(string file_name)
        {
            var work_dir = Path.GetDirectoryName( Environment.CurrentDirectory );
            var path     = work_dir + @"\" + file_name;
            
            if(System.IO.File.Exists( path ))
            {
                using(var stream = new StreamReader( path ))
                {
                    return stream.ReadToEnd();
                }
            }
            
            return string.Empty;
        }

        static public Hashtable ReadJSON(string file_name)
        {
            var work_dir = Path.GetDirectoryName( Environment.CurrentDirectory );
            var path     = work_dir + @"\" + file_name;
            
            if(System.IO.File.Exists( path ))
            {
                using(var stream = new StreamReader( path ))
                {
                    string buff = stream.ReadToEnd();
                    
                    return utils.json.Decode( buff ) as Hashtable;
                }
            }
            
            return new Hashtable();
        }

        static public void WriteJSON(string file_name, object value)
        {
            var work_dir= Environment.CurrentDirectory;
            var path    = work_dir + @"\" + file_name;
            
            StreamWriter stream = new StreamWriter( path );

            stream.Write( utils.json.Encode( value ) );
            stream.Flush();
            stream.Close();
        }
        static public List<string> ReadLineToList(string file_name)
        {
            var buff = new List<string>();

            var work_dir = Path.GetDirectoryName(Environment.CurrentDirectory);
            var path = work_dir + @"\" + file_name;

            log.print(work_dir);
            log.print(path);

            if (System.IO.File.Exists(path))
            {
                using (var stream = new StreamReader(path))
                {
                    string line = string.Empty;

                    while ( (line= stream.ReadLine()) != null)
                    {
                        line = Regex.Replace(line, @"^\s*$\n|\r",string.Empty, RegexOptions.Multiline );
                        if (line.Length == 0) continue;

                        if (Regex.IsMatch(line, @"[#]", RegexOptions.IgnoreCase)) continue;
                      
                        //log.print(line);

                        buff.Add(line);
                    }
                }
            }

            return buff;
        }
    }
}