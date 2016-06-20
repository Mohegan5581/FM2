using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FM2
{
    public partial class fmPlayerEvalForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        public fmPlayerEvalForm()
        {
            InitializeComponent();
        }
        public void readCsv(string fileName)
        {
            DataTable dt = new DataTable();

            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        adapter.Fill(dt);

                        var allLines = File.ReadAllLines(fileName);
                        var query = from line in allLines
                                    let data = line.Split(',')
                                    select new
                                    {
                                        PlayerName = data[0],
                                        Aggression = Int32.Parse(data[1]),
                                        WorkRate = Int32.Parse(data[2])
                                    };
                        //int Count = 0;

                       /* List<Player> players = new List<Player>();

                        foreach (var s in query)
                        {
                            //Count++;
                            Player newPlayer = new Player();
                            newPlayer.PlayerName = s.PlayerName;
                            newPlayer.Aggression = s.Aggression;
                            newPlayer.WorkRate = s.WorkRate;
                            players.Add(newPlayer);

                        }*/

                       /* playerContext = new fmEvalModel();

                        try
                        {
                            var playerQuery = from d in playerContext.Players
                                              orderby d.Id
                                              select d;

                            //this.departmentList.DisplayMember = "Name";
                            dataGridView.DataSource = ((ObjectQuery)playerQuery).Execute(MergeOption.AppendOnly);
                            //playersDataSet.Lo
                            //schoolContext.SaveChanges();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        */


                    }
                }
            }
        }

        private void importCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "CSV|*.csv";
            // original before I found out about ofd.Filter
            //string pattern = ".*\\.csv$";
            //if (ofd.ShowDialog() == DialogResult.OK && Regex.IsMatch(ofd.FileName.Trim(), pattern, RegexOptions.IgnoreCase))
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //Console.Write(pattern);
                //Console.Write(ofd);
                toolStripFilePath.Text = ofd.FileName;
                //dataGridView.DataSource = readCsv(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Please select a CSV only", "FM Eval", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

    }
}
