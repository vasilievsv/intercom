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

namespace l420
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
                    
                    return l420.json.Decode( buff ) as Hashtable;
                }
            }
            
            return new Hashtable();
        }

        static public void WriteJSON(string file_name, object value)
        {
            var work_dir= Environment.CurrentDirectory;
            var path    = work_dir + @"\" + file_name;
            
            StreamWriter stream = new StreamWriter( path );

            stream.Write( l420.json.Encode( value ) );
            stream.Flush();
            stream.Close();
        }

        static public List<string> ReadLineToList(string file_name)
        {
            var buff     = new List<string>();

            var work_dir = Path.GetDirectoryName(Environment.CurrentDirectory);
            var path     = work_dir + @"\" + file_name;

            if (System.IO.File.Exists(path))
            {
                using (var stream = new StreamReader(path))
                {
                    var line = stream.ReadLine();

                    while (line != null)
                    {
                        if (!Regex.IsMatch(line, @"\b[#]\w+"     , RegexOptions.IgnoreCase)) continue;
                        if (!Regex.IsMatch(line, "^((?!\r\n).)*$", RegexOptions.IgnoreCase)) continue;

                        buff.Add(line);
                    }
                }
            }

            return buff;
        }

    }
}