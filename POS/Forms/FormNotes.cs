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
            txtSearch.Select();
            txtSearch.Focus();

            notesHelper.LoadNotes(grdNoteList, "");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FormCreateNote createNote = new FormCreateNote(currUser, grdNoteList, null))
            {
                createNote.ShowDialog(this);
                createNote.Dispose();
                txtSearch.Select();
            }
        }

        private void grdNoteList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdNoteList.Columns[e.ColumnIndex].Name == "DELETE")
            {
                if (MessageBox.Show(this, "Are you sure to delete this note?", "Delete Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    notesHelper.DeleteNotes(Convert.ToInt32(grdNoteList[1, e.RowIndex].Value.ToString()));
                    notesHelper.LoadNotes(grdNoteList, "");
                    MessageBox.Show("Note Successfully Deleted", "Note Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                    txtSearch.Select();
                }
            }
        }

        private void btnCreate_TextChanged(object sender, EventArgs e)
        {
            notesHelper.LoadNotes(grdNoteList, "");
        }
    }
}
