using System.Diagnostics;
using System.Data.SQLite;
using System.Data;


namespace BrowserHistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "loading"; //change button text after click
            button1.Update();         //load the nem button text "loading"

            //---------------STOP ALL BROWSERS START---------------//
            //this session serves to close browsers that are open. If the browsers remain open, it is not possible to access the history
            Process.GetProcesses() //get the processes that are running in windows
            .Where(x => x.ProcessName.Contains("opera") ||  //filter the processes that have "opera" in the name
            x.ProcessName.Contains("chrome") || //filter the processes that have "chrome" in the name
            x.ProcessName.Contains("edge") || //filter the processes that have "edge" in the name
            x.ProcessName.Contains("firefox"))//filter the processes that have "firefox" in the name
            .ToList() //get all the processes filtered and send to a list
            .ForEach(x => x.Kill()); //close all processes in the list
            //---------------STOP ALL BROWSERS END---------------//


            //---------------EDGE START---------------//
            try
            {
                SQLiteConnection database = new SQLiteConnection(@"Data Source="  ///
                + Environment.GetEnvironmentVariable("HOMEPATH")                  ///these code get the "history" file and make a sqlite connection
                + @"\AppData\Local\Microsoft\Edge\User Data\Default\History");   ///
                database.Open(); /// open the "history" file after connection successfull
                SQLiteCommand command = new SQLiteCommand(); /// create a new var that will send the commands to the sqlite
                command.Connection = database;   /// says which is the database to send the command
                command.CommandText = "Select * From urls"; ///the command to send
                SQLiteDataReader data = command.ExecuteReader(); /// create a new var and send the answer of the command in the sqlite
                edgegrid.Columns.Add("url", "url"); /// create the "url" column to show to the user
                edgegrid.Columns.Add("Title", "Title"); /// create te "title" column to show to the user

                while (data.Read())
                {
                    edgegrid.Rows.Add(data[1].ToString(), data[2].ToString()); ///add the data received to the rows to show to the user
                }
            }
            catch { }
            //---------------EDGE END---------------//

            //---------------FIREFOX START---------------//
            try
            {
                var directories = Directory.GetDirectories(Environment.GetEnvironmentVariable("HOMEPATH")    ///
                + @"\AppData\Roaming\Mozilla\Firefox\Profiles");                                             ///firefox have many profiles, this get the all profiles folder and send to the "for" loop    
                foreach (var directory in directories)                                                       ///
                {
                    try
                    {
                        SQLiteConnection database2 = new SQLiteConnection(@"Data Source=" + directory + @"\places.sqlite");  /// get the "places.sqlite" file and make a sqlite connection
                        database2.Open(); /// open the "places.sqlite" file after connection successfull
                        SQLiteCommand command2 = new SQLiteCommand(); /// create a new var that will send the commands to the sqlite
                        command2.Connection = database2; /// says which is the database to send the command
                        command2.CommandText = "Select * From moz_places"; ///the command to send
                        SQLiteDataReader data2 = command2.ExecuteReader();/// create a new var and send the answer of the command in the sqlite
                        firefoxgrid.Columns.Add("url", "url");/// create the "url" column to show to the user
                        firefoxgrid.Columns.Add("title", "Title");/// create te "title" column to show to the user

                        while (data2.Read())
                        {
                            firefoxgrid.Rows.Add(data2[1].ToString(), data2[2].ToString()); ///add the data received to the rows to show to the user
                        }
                    }
                    catch { }
                }

            }
            catch { }
            //---------------FIREFOX END---------------//

            //---------------CHROME START---------------//
            try
            {
                SQLiteConnection database3 = new SQLiteConnection(@"Data Source="   ///
                + Environment.GetEnvironmentVariable("HOMEPATH")                    ///these code get the "history" file and make a sqlite connection
                + @"\AppData\Local\Google\Chrome\User Data\Default\History");       ///
                database3.Open();  /// open the "History" file after connection successfull
                SQLiteCommand command3 = new SQLiteCommand(); /// create a new var that will send the commands to the sqlite
                command3.Connection = database3; /// says which is the database to send the command
                command3.CommandText = "Select * From urls"; ///the command to send
                SQLiteDataReader data3 = command3.ExecuteReader(); /// create a new var and send the answer of the command in the sqlite
                chromegrid.Columns.Add("url", "url"); /// create the "url" column to show to the user
                chromegrid.Columns.Add("Title", "Title"); /// create te "title" column to show to the user

                while (data3.Read())
                {
                    chromegrid.Rows.Add(data3[1].ToString(), data3[2].ToString()); ///add the data received to the rows to show to the user
                }
            }
            catch { }
            //---------------CHROME END---------------//

            //---------------OPERAGX START---------------//
            try
            {
                SQLiteConnection database4 = new SQLiteConnection(@"Data Source=" ///
                + Environment.GetEnvironmentVariable("HOMEPATH")                  ///these code get the "history" file and make a sqlite connection
                + @"\AppData\Roaming\Opera Software\Opera GX Stable\History");    ///
                database4.Open();  /// open the "History" file after connection successfull
                SQLiteCommand command3 = new SQLiteCommand(); /// create a new var that will send the commands to the sqlite
                command3.Connection = database4; /// says which is the database to send the command
                command3.CommandText = "Select * From urls"; ///the command to send
                SQLiteDataReader data3 = command3.ExecuteReader(); /// create a new var and send the answer of the command in the sqlite
                operagxgrid.Columns.Add("url", "url"); /// create the "url" column to show to the user
                operagxgrid.Columns.Add("Title", "Title"); /// create te "title" column to show to the user

                while (data3.Read())
                {
                    operagxgrid.Rows.Add(data3[1].ToString(), data3[2].ToString()); ///add the data received to the rows to show to the user
                }
            }
            catch { }
            //---------------OPERAGX END---------------//
            groupBox1.Visible = false; // hide the layer to see the history

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void edgegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void firefoxgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chromegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void operagxgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

}