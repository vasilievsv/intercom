/**
  ******************************************************************************
  * @date    
  * @authors Sergey Vasiliev, Michael Kargapoltsev
  * @brief   
  ******************************************************************************
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
*/

using System;
using System.IO;

namespace l420
{
    public class micro
    {
        static StreamWriter     _stream = null;
        static public string    _buff   = ""; // буфер для GUI
        static int              _lcount = 0;

        ///
        ///
        ///
        static public void print(string[] type)
        {
            foreach(var p in type)
            {
                micro.print( p );
            }
        }
        ///
        ///
        ///
        static public void print(string type)
        {
            var txt = "   " + type;
            
            _buff += "\r\n"+txt;
            
            _lcount++;
            Console.Write( txt + "\n" );
            
            if(_stream != null)
            {
                _stream.WriteLine( txt );
                _stream.Flush();
            }

            if(_lcount > 5)
                micro.wipe();
            
            //single.dispatchEvent(new Xevent(Xevent.TRACE,txt))
        }
        ///
        ///
        ///
        static public void begin(object color)
        {
            Console.ForegroundColor = (ConsoleColor)color;
        }
        ///
        ///
        ///
        static public void end()
        {
            Console.ResetColor();
        }
        ///
        ///
        ///
        static public void setup(string path)
        {
            _stream = new StreamWriter( path );
        }
        ///
        ///
        ///
        static public void wipe()
        {
            _lcount = 0;
            _buff   = "";
        }
        ///
        ///
        ///
        static public void print_OS()
        {
            //micro.print("TIME:"     + DateTime.Now);
            //micro.print("LOG :"     + Environment.CurrentDirectory + @"\" + path );
            //micro.print("OS  :"     + Environment.OSVersion.Platform);
            //micro.print("ARG :\n "  + String.Join(" ", Environment.GetCommandLineArgs()));
        }

        static public void print_banner(string _msg="")
        {
            switch(DateTime.Now.Second % 8)
            {
                case 1: goto banner2;
                case 3: goto banner4;
                case 4: goto banner5;
                case 5: goto banner6;
                case 6: goto banner7;
                case 8: goto banner9;
            }


            banner2:
            micro.print( @"
                  _,----. 
               ,-'     __`. 
              /    .  /--\`) 
             /  .  )\/_,--\ 
            /  ,'\/,-'    _\_ 
           |  /  ,' ,---'  __\ 
          ,' / ,:     _,-\'_,( 
           (/ /  \ \,'   |'  _)         ,. ,.,. 
            \/   |          '  \        \ ,. \ ) 
             \, ,-              \       /,' )// 
              ; \'`      _____,-'      _|`  ,' 
               \ `'\    (_,'_)     _,-'    ,' 
                \   \       \  _,-'       ,' 
                |, , )       `'       _,-' 
                /`/ Y    ,    \   _,-' 
                   :    /      \-' 
                   |     `--.__\___ 
                   |._           __) 
         -hrr-     |  `--.___    _) 
                   |         `----' 
                  /                \ 
                 '                . ) 
" );
            return;

            banner4:
            micro.print( @"
             , 
            (                          ) 
             \                        / 
            ,' ,__,___,__,-._         ) 
            )-' ,    ,  , , (        / 
    -hrr-   ;''-^-.,-'''''\' \       ) 
           (      (        ) /  __  / 
            \o,----.  o  _,'( ,.^. \ 
            ,'`.__  `---'    `\ \ \ \_ 
     ,.,. ,'                   \    ' ) 
     \ \ \\__  ,------------.  /     / 
    ( \ \ \( `---.-`-^--,-,--\:     : 
     \       (   (""""""`----'|     : 
      \   `.  \   `.          |      \ 
       \   ;  ;     )      __ _\      \ 
       /     /    ,-.,-.''Y  Y  \      `. 
      /     :    ,`-'`-'`-'`-'`-'\       `. 
     /      ;  ,'  /              \        ` 
    /      / ,'   /                \ 
" );
            return;

            banner5:
            micro.print( @"
                           _,..__,
                       ,.'''      `'-,_
                     ,'                '.
                   ,'                    '
                  /                       \_
                 ;     -.                   `\
                 |       |     _         _    .
                ;       ,'  ,-' `.     /' `.  |
                |       '  /  o   |   t  o  \.'    .,-.
                 |         |:    .'   |:    .|    /    \
                 ;         \:.._./    ':_..:/ `. |      L
                  \  ,-'           |\_         `\-     ''-.
      ,-''``'-,    `f              '/`>                    `.
    ,'        `L___.|              '  `     . _,/            \
    |                \_          _   _    .-.]____,,r        |
    \             ,. ___''----./` \,' ',`\'  \      \     mx.'
      `'-'|        '`         `|   |   |  |  |       `'--''`
          ,         |           L_.'.__:__.-'
           \        /
            `'-- ''`" );
            return;

            banner6:
            micro.print( @"
───────▄▄▄
 ────▄▀░▄░▀▄
  ───█░█▄▀░█
   ──█░▀▄▄▀█▄█▄▀
    ▄▄█▄▄▄▄███▀
" );
            return;

            banner7:
            micro.print( @"
 ▄            ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄   ▄         ▄  ▄▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄  
▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░░░░░░░░░░░▌ ▐░░░░░░░░░▌ 
▐░▌          ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░█░█▀▀▀▀▀█░▌
▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌          ▐░▌▐░▌▐░▌    ▐░▌
▐░▌          ▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌          ▐░▌▐░▌ ▐░▌   ▐░▌
▐░▌          ▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌ ▄▄▄▄▄▄▄▄▄█░▌▐░▌  ▐░▌  ▐░▌
▐░▌          ▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌ ▀▀▀▀▀▀▀▀▀█░▌▐░░░░░░░░░░░▌▐░▌   ▐░▌ ▐░▌
▐░▌          ▐░▌       ▐░▌▐░▌       ▐░▌          ▐░▌▐░█▀▀▀▀▀▀▀▀▀ ▐░▌    ▐░▌▐░▌
▐░█▄▄▄▄▄▄▄▄▄ ▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌          ▐░▌▐░█▄▄▄▄▄▄▄▄▄ ▐░█▄▄▄▄▄█░█░▌
▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░▌           ▐░▌▐░░░░░░░░░░░▌ ▐░░░░░░░░░▌ 
 ▀▀▀▀▀▀▀▀▀▀▀  ▀         ▀  ▀▀▀▀▀▀▀▀▀▀             ▀  ▀▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀  
                                                                   [Nice job.]" );
            return;


            banner9:
            micro.print(@"
        .o oOOOOOOOo                                            OOOo
        Ob.OOOOOOOo  OOOo.      oOOo.                      .adOOOOOOO
        OboO''''''''''''.OOo. .oOOOOOo.    OOOo.oOOOOOo..'''''''''OO
        OOP.oOOOOOOOOOOO 'POOOOOOOOOOOo.   `'OOOOOOOOOP,OOOOOOOOOOOB'
        `O'OOOO'     `OOOOo'OOOOOOOOOOO` .adOOOOOOOOO'oOOO'    `OOOOo
        .OOOO'            `OOOOOOOOOOOOOOOOOOOOOOOOOO'            `OO
        OOOOO                 ''OOOOOOOOOOOOOOOO'`                oOO
       oOOOOOba.                .adOOOOOOOOOOba               .adOOOOo.
      oOOOOOOOOOOOOOba.    .adOOOOOOOOOO@^OOOOOOOba.     .adOOOOOOOOOOOO
     OOOOOOOOOOOOOOOOO.OOOOOOOOOOOOOO'`  ''OOOOOOOOOOOOO.OOOOOOOOOOOOOO
     'OOOO'       'YOoOOOOMOIONODOO'`  .   ''OOROAOPOEOOOoOY'     'OOO'
        Y           'OOOOOOOOOOOOOO: .oOOo. :OOOOOOOOOOO?'         :`
        :            .oO%OOOOOOOOOOo.OOOOOO.oOOOOOOOOOOOO?         .
        .            oOOP'%OOOOOOOOoOOOOOOO?oOOOOO?OOOO'OOo
                     '%o  OOOO'%OOOO%'%OOOOO'OOOOOO'OOO':
                          `$'  `OOOO' `O'Y ' `OOOO'  o             .
        .                  .     OP'          : o     .
                                  :
                                  .
");
            return;
        }
    }//class end
}