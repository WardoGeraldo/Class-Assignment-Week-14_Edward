using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClassAsg_W14_Edward_Geraldo
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter SqlDataAdapter;
        DataTable dt;
        DataTable teamHome;
        DataTable teamAway;
        DataTable player;
        string SqlQuery;
        string coba;
        string idHome;
        string idAway;
        string idTeam;
        int indexNow;
        private void mainForm_Load(object sender, EventArgs e)
        {
            try
            {
                tb_matchID.Enabled = false;
                sqlConnect = new MySqlConnection($"server = localhost; uid = root; pwd = isbmantap; database = premier_league;");
                dt = new DataTable();
                teamHome = new DataTable();
                teamAway = new DataTable();
                SqlQuery = "select * from team";
                sqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                SqlDataAdapter.Fill(teamHome);
                SqlDataAdapter.Fill(teamAway);
                cbox_home.DataSource = teamHome;
                cbox_home.DisplayMember = "team_name";
                cbox_home.ValueMember = "team_id";
                cbox_away.DataSource = teamAway;
                cbox_away.DisplayMember = "team_name";
                cbox_away.ValueMember = "team_id";
                dt.Columns.Add("Team Name");
                dt.Columns.Add("Player");
                dt.Columns.Add("Type");
                dt.Columns.Add("Minute");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(cbox_team.Text, cbox_player.Text, cbox_type.Text, tb_minute.Text);
            dgv.DataSource = dt;

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            dt.Rows.RemoveAt(indexNow);
            dgv.DataSource = dt;
        }

        private void cbox_player_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickers_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string year = dateTimePickers.Value.Year.ToString();
                SqlQuery = $"select count(match_id) from `match` where match_id like '{year}%';";
                sqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
                DataTable dtCount = new DataTable();
                SqlDataAdapter.Fill(dtCount);
                tb_matchID.Text = $"{year}{(Convert.ToInt32(dtCount.Rows[0][0]) + 1).ToString()}";
                //dtCount.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbox_home_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_home.SelectedIndex == -1 && cbox_away.SelectedIndex == -1)
            {

            }
            else
            {
                if (cbox_away.Text != cbox_home.Text)
                {
                    cbox_team.Items.Clear();
                    idHome = Convert.ToString(cbox_home.SelectedValue);
                    idAway = Convert.ToString(cbox_away.SelectedValue);
                    cbox_team.Items.Add(cbox_home.Text);
                    cbox_team.Items.Add(cbox_away.Text);
                }
                else
                {
                    MessageBox.Show("Team Home & Away cant be the same");
                }
            }
        }

        private void cbox_away_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbox_home.SelectedIndex == -1 && cbox_away.SelectedIndex == -1)
            {

            }
            else
            {
                if (cbox_away.Text != cbox_home.Text)
                {
                    cbox_team.Items.Clear();
                    idHome = Convert.ToString(cbox_home.SelectedValue);
                    idAway = Convert.ToString(cbox_away.SelectedValue);
                    cbox_team.Items.Add(cbox_home.Text);
                    cbox_team.Items.Add(cbox_away.Text);
                }
                else
                {
                    MessageBox.Show("Team Home & Away cant be the same");
                }
            }
        }

        private void cbox_team_SelectedIndexChanged(object sender, EventArgs e)
        {
            player = new DataTable();
            if (cbox_team.SelectedIndex == 0)
            {
                idTeam = idHome;
            }
            if (cbox_team.SelectedIndex == 1)
            {
                idTeam = idAway;
            }
            SqlQuery = $"select player_id, player_name from player where team_id like '%{idTeam}%';";
            sqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
            SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            SqlDataAdapter.Fill(player);
            cbox_player.DataSource = player;
            cbox_player.DisplayMember = "player_name";
            cbox_player.ValueMember = "player_id";
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexNow = e.RowIndex;
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in dt.Rows)
            {

            }
            try
            {
                SqlQuery = $"insert into `match` values ('{tb_matchID.Text}', '{dateTimePickers.Value}', '{idHome}', '{idAway}', 'goal_home', 'goal_away', 'M002', 0";
                sqlCommand= new MySqlCommand(SqlQuery, sqlConnect);
                SqlDataAdapter = new MySqlDataAdapter( sqlCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlQuery = $"insert into `dmatch` values ('{tb_matchID.Text}', '{tb_minute.Text}', 'team_id', 'player_id', '{cbox_type.SelectedIndex}, 0";
                sqlCommand = new MySqlCommand(SqlQuery, sqlConnect);
                SqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
