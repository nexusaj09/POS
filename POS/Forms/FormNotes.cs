using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using POS.Classes;
using POS.Helpers;

namespace POS.Forms
{
    public partial class FormNotes : MetroForm
    {

        public User currUser = new User();
        private NotesHelper notesHelper = new NotesHelper();

        public FormNotes(User user)
        {
            InitializeComponent();

            this.currUser = user;
        }

        private void FormNotes_Load(object sender, EventArgs e)
        {

            notesHelper.LoadNotes(grdNoteList, "");

            Init();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateNote createNote = new FormCreateNote(currUser, grdNoteList, null))
            {
                createNote.ShowDialog(this);
                createNote.Dispose();
                Init();
            }
        }

        private void grdNoteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdNoteList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                DeleteNotes(e.RowIndex);
            }
            else if (grdNoteList.Columns[e.ColumnIndex].Name == "EDIT")
            {
                Notes updateNote = new Notes();
                updateNote.ID = Convert.ToInt32(grdNoteList[1, e.RowIndex].Value.ToString());
                updateNote.Title = grdNoteList[2, e.RowIndex].Value.ToString();
                updateNote.Description = grdNoteList[3, e.RowIndex].Value.ToString();

                using (FormCreateNote createNote = new FormCreateNote(currUser, grdNoteList, updateNote))
                {
                    createNote.btnSave.Text = "UPDATE";
                    createNote.ShowDialog(this);
                    createNote.Dispose();
                    Init();
                }
            }
        }


        public void txtFocus()
        {
            txtSearch.Select();
            txtSearch.Focus();
        }

        public void Init()
        {
            txtFocus();

            grdNoteList.ClearSelection();

            grdNoteList.CurrentCell = null;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            notesHelper.LoadNotes(grdNoteList, txtSearch.Text);

            if (grdNoteList.Rows.Count > 0)
            {
                Init();
            }
        }

        private void grdNoteList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Selected)
            {
                e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                // edit: to change the background color:
                e.CellStyle.SelectionBackColor = Color.Coral;
            }
        }

        private void FormNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Init();

            }
            else if (e.KeyCode == Keys.Down && txtSearch.ContainsFocus && grdNoteList.Rows.Count > 0)
            {

                grdNoteList.Select();
                grdNoteList.Rows[0].Selected = true;

            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Delete && grdNoteList.Rows.Count > 0 && grdNoteList.ContainsFocus)
            {
                DeleteNotes(grdNoteList.CurrentCell.RowIndex);
            }
        }

        private void DeleteNotes(int row)
        {
            if (MessageBox.Show(this, "Are you sure to delete this note?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                notesHelper.DeleteNotes(Convert.ToInt32(grdNoteList[1, row].Value.ToString()));
                notesHelper.LoadNotes(grdNoteList, "");
                MessageBox.Show("Note Successfully Deleted", "Note Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
