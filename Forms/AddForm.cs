using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotesApplication.Controllers;
using NotesApplication.DAO;
using NotesApplication.Data;
using NotesApplication.Services;

namespace NotesApplication.Forms
{
    public partial class AddForm : Form
    {
        private readonly NotesController _noteController;
        public event Action NoteAdded;
        public AddForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NotesRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NotesController(noteService);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string Content = rtxtContent.Text;

            _noteController.AddNote(Title, Content);
            MessageBox.Show($"Added Successfully!\nDate: {DateTime.Now:yyyy-MM-dd}", "Information");

            //Raise the event to notify the Main Form
            NoteAdded?.Invoke();
            this.Close();
        }
    }
}
