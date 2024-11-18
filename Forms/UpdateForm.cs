using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApplication.Controllers;
using NotesApplication.DAO;
using NotesApplication.Data;
using NotesApplication.Models;
using NotesApplication.Services;

namespace NotesApplication.Forms
{
    public partial class UpdateForm : Form
    {
        private readonly NotesController _notesController;
        public event Action<NotesItem> NoteUpdated;
        private NotesItem _note;
        public UpdateForm(NotesItem notesItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NotesRepository(context);
            var noteService = new NoteService(noteRepository);
            _notesController = new NotesController(noteService);

            _note = notesItem;
            PopulateFormFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string Content = rtxtContent.Text;

            _note.NoteTitle = Title;
            _note.NoteContent = Content;
            _note.Date = DateTime.Now;

            NoteUpdated?.Invoke(_note);
            this.Close();
        }
        private void PopulateFormFields()
        {
            txtTitle.Text = _note.NoteTitle;
            rtxtContent.Text = _note.NoteContent;
            lblDate.Text = $"Last Updated: {_note.Date:yyyy-MM-dd}";
        }
    }
}
