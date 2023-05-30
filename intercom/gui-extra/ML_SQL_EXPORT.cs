/**
  ******************************************************************************
  * @date    
  * @version V0.0.0
  * @author  Vasiliev Sergey
  * @brief   
  ******************************************************************************
*/
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using utils;
using micro.sdk;
using SQLite;


namespace app
{

    public partial class ML_SQL_EXPORT : Form
    {
        public ML_SQL_EXPORT()
        {
            InitializeComponent();

        }

        #region DRAG_AND_DROP

        void Form1_DragEnter(object sender, DragEventArgs e)
        {
            var _drop = e.Data.GetDataPresent( DataFormats.FileDrop );
            if (_drop)
                e.Effect = DragDropEffects.Copy;
        }

        void Form1_DragDrop(object sender, DragEventArgs e)
        {


        string [ ] files = (string [ ])e.Data.GetData( DataFormats.FileDrop );
            foreach(string file in files)
            { 
                Console.WriteLine( file );
                Console.ForegroundColor = ConsoleColor.Green;
                log.print( "CATCH.DragDrop " + file );


                // Get an absolute path to the database file
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), file);

                var _out_file = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                var db = new SQLiteConnection(file);

                var query_data = db.Query<Stock>("select * from records");

                // Write sample data to CSV file
                using (CsvFileWriter writer = new CsvFileWriter(_out_file + "/ml_dataset_485.csv"))
                {
                        CsvRow row = new CsvRow();

                        row.Add("h1_timestamp_us");
                        row.Add("h2_fnv_masked_slave_input");
                        row.Add("h3_bytes_input");
                        row.Add("h4_transmit_time_ms");
                        row.Add("h5_fnv_masked_slave_output");
                        row.Add("h6_bytes_output");

                        writer.WriteRow(row);
                    row.Clear();

                    foreach (var p in query_data)
                    {
                        var h1 = Convert.ToString( p.timestamp_us );
                        var h2 = Convert.ToString( p.fnv_masked_slave_input );
                        var h3 = "0x" + BitConverter.ToString( p.bytes_input).Replace("-", string.Empty);
                        var h4 = Convert.ToString( p.transmit_time_ms );
                        var h5 = Convert.ToString( p.fnv_masked_slave_output);
                        var h6 = "0x"+BitConverter.ToString( (p.bytes_output==null)?new byte[0]:p.bytes_output ).Replace("-", string.Empty);


                        row.Add(h1);
                        row.Add(h2);
                        row.Add(h3);
                        row.Add(h4);
                        row.Add(h5);
                        row.Add(h6);
                        writer.WriteRow(row);
                        row.Clear();

                    }

                }
            }
        }
        #endregion

        private void winform_BitmapStatic_Load(object sender, EventArgs e)
        {
            #region DRAG_AND_DROP
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop  += new DragEventHandler(Form1_DragDrop);
            #endregion
        }


    };



    class Stock
    {
        [PrimaryKey, AutoIncrement]
        public Int64 timestamp_us { get; set; }
        public int fnv_masked_slave_input { get; set; }
        public byte[] bytes_input { get; set; }
        public Int64 transmit_time_ms { get; set; }
        public int fnv_masked_slave_output { get; set; }
        public byte[] bytes_output { get; set; }

    };

}
