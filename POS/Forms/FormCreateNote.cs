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
    public partial class FormCreateNote : MetroForm
    {

        public User currUser = new User();
        private NotesHelper noteHelper = new NotesHelper();
        private DataGridView dataGrid = new DataGridView();
        private Notes updateNote = new Notes();
        public FormCreateNote(User user, DataGridView dataGrid, Notes updateNote)
        {
            InitializeComponent();

            this.currUser = user;
            this.dataGrid = dataGrid;
            this.updateNote = updateNote;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSave.Text == "SAVE")
                {
                    if (MessageBox.Show(this, "Add this note?", "Add Note", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Notes newNote = new Notes();

                        newNote.Title = txtTitle.Text;
                        newNote.Description = txtDescr.Text;
                        newNote.CreatedByID = currUser.UserID;
                        newNote.CreatedDateTime = DateTime.Now;
                        newNote.LastModifiedByID = currUser.UserID;
                        newNote.LastModifiedDateTime = DateTime.Now;

                        noteHelper.CreateNotes(newNote);

                        MessageBox.Show(this, "New Note Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtTitle.Clear();
                        txtDescr.Clear();

                        noteHelper.LoadNotes(dataGrid, "");

                    }
                }
                else if (btnSave.Text == "UPDATE")
                {

                    if (MessageBox.Show(this, "Are you sure to update this note?", "Updating Note", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        updateNote.Description = txtDescr.Text;
                        updateNote.Title = txtTitle.Text;
                        updateNote.LastModifiedByID = currUser.UserID;
                        updateNote.LastModifiedDateTime = DateTime.Now;

                        noteHelper.UpdateNotes(updateNote);
                        MessageBox.Show(this, "Note successfully updated!", "Updated Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        noteHelper.LoadNotes(dataGrid, "");
                        this.Close();

                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCreateNote_Load(object sender, EventArgs e)
        {
            if (updateNote != null)
            {
                txtDescr.Text = updateNote.Description;
                txtTitle.Text = updateNote.Title;
            }
        }
    }
}
