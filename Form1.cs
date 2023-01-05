using filmek.Properties;
using Microsoft.Data.SqlClient;

namespace filmek
{
    public partial class Form1 : Form
    {
        private int selectedId = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void dgvLoad()
        {
            ClearFields();
            dgv.Rows.Clear();
            using SqlConnection conn = new(Resources.ConnectionString);
            conn.Open();
            SqlDataReader rdr = new SqlCommand(
                "SELECT cim,megjeve,korhatar,hossz,filmid FROM film",
                conn).ExecuteReader();

            while (rdr.Read())
                dgv.Rows.Add(
                    rdr[0],
                    rdr[1],
                    rdr[2],
                    rdr[3],
                    rdr[4]);
            dgv.ClearSelection();
        }
        private void ClearFields()
        {
            tbCimUpdate.Text = null;
            tbKorhatarUpdate.Text = null;
            tbMegjeveUpdate.Text = null;
            tbHosszUpdate.Text = null;
            tbCimInsert.Text= null;
            tbMegjeveInsert.Text= null;
            tbKorhatarInsert.Text= null;
            tbHosszInsert.Text= null;
        }
        private static bool KiVanToltve(string mezo)
        {
            if (string.IsNullOrWhiteSpace(mezo))
            {
                _ = MessageBox.Show(
                   caption: "HIBA",
                   text: "A 'név' mezõ kitöltése kötelezõ!",
                   buttons: MessageBoxButtons.OK,
                   icon: MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvLoad();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCimUpdate.Text = $"{dgv[0, e.RowIndex].Value}";
            tbMegjeveUpdate.Text = $"{dgv[1, e.RowIndex].Value}";
            tbKorhatarUpdate.Text = $"{dgv[2, e.RowIndex].Value}";
            tbHosszUpdate.Text = $"{dgv[3, e.RowIndex].Value}";
            selectedId = (int)dgv[4, e.RowIndex].Value;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (KiVanToltve(tbCimUpdate.Text))
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    UpdateCommand = new(
                        cmdText: "UPDATE film SET " +
                        $"cim = '{tbCimUpdate.Text}', " +
                        $"megjeve = {tbMegjeveUpdate.Text}, " +
                        $"korhatar = {tbKorhatarUpdate.Text}, " +
                        $"hossz = {tbHosszUpdate.Text}" +
                        $"WHERE filmid = {selectedId};",
                        connection: conn),
                };
                sda.UpdateCommand.ExecuteNonQuery();
                dgvLoad();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (KiVanToltve(tbCimInsert.Text))
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    InsertCommand = new(
                        cmdText: "INSERT INTO film VALUES " +
                        $"('{tbCimInsert.Text}', {tbMegjeveInsert.Text}, {tbKorhatarInsert.Text}, {tbHosszInsert.Text}, NULL);",
                        connection: conn),
                };
                sda.InsertCommand.ExecuteNonQuery();
                dgvLoad();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                caption: "MEGERÕSÍTÉS",
                text: "Biztos, hogy törölni kívánod a kijelölt rekordot?",
                buttons: MessageBoxButtons.YesNo,
                icon: MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using SqlConnection conn = new(Resources.ConnectionString);
                conn.Open();

                SqlDataAdapter sda = new()
                {
                    DeleteCommand = new(
                        $"DELETE FROM film WHERE " +
                        $"filmid = {selectedId};", conn),
                };
                sda.DeleteCommand.ExecuteNonQuery();
                dgvLoad();
            }
        }
    }
}