using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FM2
{
    public partial class fmPlayerEvalForm : Form
    {
        OpenFileDialog ofd = new OpenFileDialog();
        Fm2ModelContainer context = new Fm2ModelContainer();

        public fmPlayerEvalForm()
        {
            InitializeComponent();
            try
            {
                var playerQuery = from d in context.Players
                                  orderby d.Id
                                  select d;

                //MessageBox.Show(playerQuery);
                //this.departmentList.DisplayMember = "Name";
                playerGrid.DataSource = playerQuery.ToList();
                //playersDataSet.Lo
                //schoolContext.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void readCsv(string fileName)
        {
            //DataTable dt = new DataTable();

            using (OleDbConnection cn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"" + Path.GetDirectoryName(fileName) + "\";Extended Properties='text;HDR=yes;FMT=Delimited(,)';"))
            {
                using (OleDbCommand cmd = new OleDbCommand(string.Format("select * from [{0}]", new FileInfo(fileName).Name), cn))
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                    {
                        //adapter.Fill(dt);

                        var allLines = File.ReadAllLines(fileName);
                        var query = from line in allLines
                                    let data = line.Split(',')
                                    select new
                                    {
                                        PlayerName = data[0],
                                        Aggression = Int16.Parse(data[1]),
                                        WorkRate = Int16.Parse(data[2])
                                    };
                        //int Count = 0;
                        

                        foreach (var s in query)
                        {
                            //Count++;
                            Player newPlayer = new Player();
                            newPlayer.PlayerName = s.PlayerName;
                            newPlayer.Aggression = s.Aggression;
                            newPlayer.WorkRate = s.WorkRate;
                            //using ()
                            //{
                                context.Players.Add(newPlayer);
                                context.SaveChanges();
                            //}
                            //players.Add(newPlayer);
                            
                            Console.Write(s.PlayerName);
                        }

                        //Fm2ModelContainer  = new Fm2ModelContainer();

                        try
                        {
                            var playerQuery = from d in context.Players
                                              orderby d.Id
                                              select d;
                            
                            playerGrid.DataSource = playerQuery.ToList();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        


                    }
                }
            }
        }

        private void importCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "CSV|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                toolStripFilePath.Text = ofd.FileName;
                readCsv(ofd.FileName);
            }
            else
            {
                MessageBox.Show("Please select a CSV only", "FM Eval", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

        }

        private void clearData_Click(object sender, EventArgs e)
        {
            var allPlayers = context.Players.Where(p => p.Id > 0);
            context.Players.RemoveRange(allPlayers);
            context.SaveChanges();

            var playerQuery = from d in context.Players
                              orderby d.Id
                              select d;

            playerGrid.DataSource = playerQuery.ToList();
        }
    }
}
