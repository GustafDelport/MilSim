using MilSim.Forms;
using MilSim.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilSim
{
    public partial class pnlSimOptions : Form
    {
        public pnlSimOptions()
        {
            InitializeComponent();
        }

        //===================================================================================================================================
        //Essentials
        //===================================================================================================================================
        #region Essentials
        private void Simulation_Load(object sender, EventArgs e)
        {
            //Globals.UserLogged = "Admin";

            Globals.Plane = new DataHandler().GetPlane("JTONE",this.picPlane);
            Globals.Plane.Plane1();

            if (Globals.UserLogged == "Admin")
            {
                picAdmin.Visible = true;
            }
            else { picAdmin.Visible = false; }

            popOuter();
            Globals.Plane.Box.Visible = false;
            Globals.Base = new Base();
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Clicks
        //===================================================================================================================================
        #region Clicks
        private void picExit_Click(object sender, EventArgs e)
        {
            Globals.main.Show();
            Globals.simulation.Hide();
        }

        private void picAdmin_Click(object sender, EventArgs e)
        {
            Server S = new Server();
            new Thread(new ThreadStart(() => S.ServerStart())).Start();

            string appPath = Path.GetFullPath(@"..\..\..\Admin_Panel\Bin\Debug\Admin_Panel.exe");
            System.Diagnostics.Process.Start(appPath);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Maze maze = new Maze();
            maze.CreateMaze(this.pnlSim);
            if (Globals.shortestPath != null)
            {
                new Animation().BeginFlight(Globals.Plane.Box, pnlSim);
            }
            else
            {
                MessageBox.Show("Please Check All Constraints");
            }
        }

        private void btnCreateBase_Click_1(object sender, EventArgs e)
        {
            Globals.baseInfo.Show();
            Globals.simulation.Hide();
        }

        private void btnChangePlane_Click(object sender, EventArgs e)
        {
            Globals.planeSettings.Show();
            Globals.simulation.Hide();
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Animantions
        //===================================================================================================================================
        #region Animations
        private void picAdmin_MouseEnter(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel2;
        }

        private void picAdmin_MouseLeave(object sender, EventArgs e)
        {
            picAdmin.Image = Resources.Admin_Panel1;
        }

        private void picExit_MouseEnter_1(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnTwo;
        }

        private void picExit_MouseLeave_1(object sender, EventArgs e)
        {
            picExit.Image = Resources.ReturnOne;
        }

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Other Misc
        //===================================================================================================================================
        #region Others

        public void popOuter()
        {
            string path = Path.GetFullPath(@"..\..\Resources\Wall1.png");
            //Top Wall
            pictureBox155.Load(path);
            pictureBox156.Load(path);
            pictureBox157.Load(path);
            pictureBox158.Load(path);
            pictureBox159.Load(path);
            pictureBox160.Load(path);
            pictureBox161.Load(path);
            pictureBox162.Load(path);
            pictureBox163.Load(path);
            pictureBox164.Load(path);
            pictureBox165.Load(path);
            pictureBox166.Load(path);
            pictureBox167.Load(path);
            pictureBox168.Load(path);
            pictureBox169.Load(path);
            pictureBox170.Load(path);
            pictureBox171.Load(path);

            //Right Wall
            pictureBox137.Load(path);
            pictureBox154.Load(path);
            pictureBox86.Load(path);
            pictureBox103.Load(path);
            pictureBox69.Load(path);
            pictureBox120.Load(path);
            pictureBox52.Load(path);
            pictureBox35.Load(path);
            pictureBox2.Load(path);
            pictureBox169.Load(path);
            //Bottom Wall
            pictureBox3.Load(path);
            pictureBox4.Load(path);
            pictureBox5.Load(path);
            pictureBox6.Load(path);
            pictureBox7.Load(path);
            pictureBox8.Load(path);
            pictureBox9.Load(path);
            pictureBox10.Load(path);
            pictureBox11.Load(path);
            pictureBox12.Load(path);
            pictureBox13.Load(path);
            pictureBox14.Load(path);
            pictureBox15.Load(path);
            pictureBox16.Load(path);
            pictureBox17.Load(path);
            pictureBox18.Load(path);
            //Left Wall
            pictureBox121.Load(path);
            pictureBox138.Load(path);
            pictureBox70.Load(path);
            pictureBox87.Load(path);
            pictureBox104.Load(path);
            pictureBox53.Load(path);
            pictureBox36.Load(path);
            pictureBox19.Load(path);

        }

        private void pic1_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic1;
            Globals.baseBuild.Show();
        }

        private void pic120_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic120;
            Globals.baseBuild.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic2;
            Globals.baseBuild.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic3;
            Globals.baseBuild.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic4;
            Globals.baseBuild.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic5;
            Globals.baseBuild.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic6;
            Globals.baseBuild.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic7;
            Globals.baseBuild.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic8;
            Globals.baseBuild.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic9;
            Globals.baseBuild.Show();
        }

        private void pic10_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic10;
            Globals.baseBuild.Show();
        }

        private void pic11_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic11;
            Globals.baseBuild.Show();
        }

        private void pic12_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic12;
            Globals.baseBuild.Show();
        }

        private void pic13_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic13;
            Globals.baseBuild.Show();
        }

        private void pic14_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic14;
            Globals.baseBuild.Show();
        }

        private void pic15_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic15;
            Globals.baseBuild.Show();
        }

        private void pic16_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic16;
            Globals.baseBuild.Show();
        }

        private void pic17_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic17;
            Globals.baseBuild.Show();
        }

        private void pic18_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic18;
            Globals.baseBuild.Show();
        }

        private void pic19_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic19;
            Globals.baseBuild.Show();
        }

        private void pic20_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic20;
            Globals.baseBuild.Show();
        }

        private void pic21_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic21;
            Globals.baseBuild.Show();
        }

        private void pic22_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic22;
            Globals.baseBuild.Show();
        }

        private void pic23_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic23;
            Globals.baseBuild.Show();
        }

        private void pic24_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic24;
            Globals.baseBuild.Show();
        }

        private void pic25_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic25;
            Globals.baseBuild.Show();
        }

        private void pic26_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic26;
            Globals.baseBuild.Show();
        }

        private void pic27_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic27;
            Globals.baseBuild.Show();
        }

        private void pic28_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic28;
            Globals.baseBuild.Show();
        }

        private void pic29_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic29;
            Globals.baseBuild.Show();
        }

        private void pic30_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic30;
            Globals.baseBuild.Show();
        }

        private void pic31_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic31;
            Globals.baseBuild.Show();
        }

        private void pic32_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic32;
            Globals.baseBuild.Show();
        }

        private void pic33_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic33;
            Globals.baseBuild.Show();
        }

        private void pic34_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic34;
            Globals.baseBuild.Show();
        }

        private void pic35_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic35;
            Globals.baseBuild.Show();
        }

        private void pic36_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic36;
            Globals.baseBuild.Show();
        }

        private void pic37_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic37;
            Globals.baseBuild.Show();
        }

        private void pic38_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic38;
            Globals.baseBuild.Show();
        }

        private void pic39_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic39;
            Globals.baseBuild.Show();
        }

        private void pic40_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic40;
            Globals.baseBuild.Show();
        }

        private void pic41_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic41;
            Globals.baseBuild.Show();
        }

        private void pic42_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic42;
            Globals.baseBuild.Show();
        }

        private void pic43_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic43;
            Globals.baseBuild.Show();
        }

        private void pic44_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic44;
            Globals.baseBuild.Show();
        }

        private void pic45_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic45;
            Globals.baseBuild.Show();
        }

        private void pic46_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic46;
            Globals.baseBuild.Show();
        }

        private void pic47_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic47;
            Globals.baseBuild.Show();
        }

        private void pic48_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic48;
            Globals.baseBuild.Show();
        }

        private void pic49_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic49;
            Globals.baseBuild.Show();
        }

        private void pic50_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic50;
            Globals.baseBuild.Show();
        }

        private void pic51_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic51;
            Globals.baseBuild.Show();
        }

        private void pic52_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic52;
            Globals.baseBuild.Show();
        }

        private void pic53_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic53;
            Globals.baseBuild.Show();
        }

        private void pic54_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic54;
            Globals.baseBuild.Show();
        }

        private void pic55_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic55;
            Globals.baseBuild.Show();
        }

        private void pic56_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic56;
            Globals.baseBuild.Show();
        }

        private void pic57_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic57;
            Globals.baseBuild.Show();
        }

        private void pic58_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic58;
            Globals.baseBuild.Show();
        }

        private void pic59_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic59;
            Globals.baseBuild.Show();
        }

        private void pic60_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic60;
            Globals.baseBuild.Show();
        }

        private void pic61_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic61;
            Globals.baseBuild.Show();
        }

        private void pic62_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic62;
            Globals.baseBuild.Show();
        }

        private void pic63_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic63;
            Globals.baseBuild.Show();
        }

        private void pic64_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic64;
            Globals.baseBuild.Show();
        }

        private void pic65_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic65;
            Globals.baseBuild.Show();
        }

        private void pic66_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic66;
            Globals.baseBuild.Show();
        }

        private void pic67_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic67;
            Globals.baseBuild.Show();
        }

        private void pic68_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic68;
            Globals.baseBuild.Show();
        }

        private void pic69_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic69;
            Globals.baseBuild.Show();
        }

        private void pic70_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic70;
            Globals.baseBuild.Show();
        }

        private void pic71_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic71;
            Globals.baseBuild.Show();
        }

        private void pic72_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic72;
            Globals.baseBuild.Show();
        }

        private void pic73_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic73;
            Globals.baseBuild.Show();
        }

        private void pic74_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic74;
            Globals.baseBuild.Show();
        }

        private void pic75_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic75;
            Globals.baseBuild.Show();
        }

        private void pic76_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic76;
            Globals.baseBuild.Show();
        }

        private void pic77_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic77;
            Globals.baseBuild.Show();
        }

        private void pic78_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic78;
            Globals.baseBuild.Show();
        }

        private void pic79_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic79;
            Globals.baseBuild.Show();
        }

        private void pic80_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic80;
            Globals.baseBuild.Show();
        }

        private void pic81_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic81;
            Globals.baseBuild.Show();
        }

        private void pic82_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic82;
            Globals.baseBuild.Show();
        }

        private void pic83_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic83;
            Globals.baseBuild.Show();
        }

        private void pic84_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic84;
            Globals.baseBuild.Show();
        }

        private void pic85_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic85;
            Globals.baseBuild.Show();
        }

        private void pic86_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic86;
            Globals.baseBuild.Show();
        }

        private void pic87_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic87;
            Globals.baseBuild.Show();
        }

        private void pic88_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic88;
            Globals.baseBuild.Show();
        }

        private void pic89_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic89;
            Globals.baseBuild.Show();
        }

        private void pic90_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic90;
            Globals.baseBuild.Show();
        }

        private void pic91_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic91;
            Globals.baseBuild.Show();
        }

        private void pic92_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic82;
            Globals.baseBuild.Show();
        }

        private void pic93_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic93;
            Globals.baseBuild.Show();
        }

        private void pic94_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic94;
            Globals.baseBuild.Show();
        }

        private void pic95_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic95;
            Globals.baseBuild.Show();
        }

        private void pic96_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic96;
            Globals.baseBuild.Show();
        }

        private void pic97_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic97;
            Globals.baseBuild.Show();
        }

        private void pic98_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic98;
            Globals.baseBuild.Show();
        }

        private void pic99_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic99;
            Globals.baseBuild.Show();
        }

        private void pic100_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic100;
            Globals.baseBuild.Show();
        }

        private void pic101_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic101;
            Globals.baseBuild.Show();
        }

        private void pic102_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic102;
            Globals.baseBuild.Show();
        }

        private void pic103_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic103;
            Globals.baseBuild.Show();
        }

        private void pic104_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic104;
            Globals.baseBuild.Show();
        }

        private void pic105_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic105;
            Globals.baseBuild.Show();
        }

        private void pic106_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic106;
            Globals.baseBuild.Show();
        }

        private void pic107_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic107;
            Globals.baseBuild.Show();
        }

        private void pic108_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic108;
            Globals.baseBuild.Show();
        }

        private void pic109_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic109;
            Globals.baseBuild.Show();
        }

        private void pic110_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic110;
            Globals.baseBuild.Show();
        }

        private void pic112_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic112;
            Globals.baseBuild.Show();
        }

        private void pic111_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic111;
            Globals.baseBuild.Show();
        }

        private void pic113_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic113;
            Globals.baseBuild.Show();
        }

        private void pic114_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic114;
            Globals.baseBuild.Show();
        }

        private void pic115_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic115;
            Globals.baseBuild.Show();
        }

        private void pic116_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic116;
            Globals.baseBuild.Show();
        }

        private void pic117_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic117;
            Globals.baseBuild.Show();
        }

        private void pic118_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic118;
            Globals.baseBuild.Show();
        }

        private void pic119_Click(object sender, EventArgs e)
        {
            Globals.Base.box = pic119;
            Globals.baseBuild.Show();
        }
        #endregion
        //===================================================================================================================================
        //===================================================================================================================================


        //===================================================================================================================================
        //Form Methods
        //===================================================================================================================================
        #region Methods

        #endregion
        //===================================================================================================================================
        //===================================================================================================================================
    }
}
