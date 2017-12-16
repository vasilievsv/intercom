/**
  ******************************************************************************
   *@date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   Legacy
  ******************************************************************************
*/

using System;

public static partial class Utils
{
    //
    // https://stackoverflow.com/questions/2683442/where-can-i-find-the-clamp-function-in-net
    //
    static public T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
    {
        if(val.CompareTo( min ) < 0)
            return min;
        else if(val.CompareTo( max ) > 0)
            return max;
        else
            return val;
    }
    ///
    /// Остаток от деления
    ///
    static public int Mod(int x, int period)
    {
        int r = x % period;

        return (r >= 0) ? r : r + period;
    }
    ///
    ///
    ///
    static public float ClampAngle(float angle, float min, float max)
    {
        if(angle < -360)
            angle += 360f;
        if(angle > 360)
            angle -= 360f;

        return angle.Clamp( min, max ); // extension cool :)
                                        //return Math.Clamp(angle, );
    }
    ///
    ///
    ///
    static public string EncodeString(string txt)
    {
        byte [ ] buff = System.Text.Encoding.UTF8.GetBytes( txt );
        txt = System.Convert.ToBase64String( buff );

        return txt;
    }
    ///
    ///
    ///				
    static public byte [ ] GetBytes(string str)
    {
        byte [ ] bytes = new byte [str.Length * sizeof( char )];
        System.Buffer.BlockCopy( str.ToCharArray(), 0, bytes, 0, bytes.Length );
        return bytes;
    }
    ///
    ///
    ///	
    static public string GetString(byte [ ] bytes)
    {
        //char[] chars = new char[bytes.Length / sizeof(char)];
        char [ ] chars = new char [bytes.Length];
        System.Buffer.BlockCopy( bytes, 0, chars, 0, bytes.Length );
        return new string( chars );
    }
    ///
    ///
    ///
    static public string SecondToTime(float value)
    {
        string minutes = Math.Floor( value / 60 ).ToString( "00" );
        string seconds = (value % 60).ToString( "00" );

        return minutes + ":" + seconds;
    }
    //
    //https://stackoverflow.com/questions/311165/how-do-you-convert-a-byte-array-to-a-hexadecimal-string-and-vice-versa
    public static byte [ ] StringToByteArray(String hex)
    {
        int NumberChars = hex.Length;
        byte [ ] bytes = new byte [NumberChars / 2];
        for(int i = 0; i < NumberChars; i += 2)
            bytes [i / 2] = Convert.ToByte( hex.Substring( i, 2 ), 16 );

        Array.Reverse( bytes, 0, bytes.Length );
        return bytes;
    }
    //
    //
    //https://dmadan.wordpress.com/2011/08/17/c-convert-hexadecimal-to-binary-string-conversion/
    public static string hex2binary(string hexvalue)
    {
        string binaryval = string.Empty;
        binaryval = Convert.ToString(Convert.ToInt32(hexvalue, 16), 2);
        return binaryval;
    }

}