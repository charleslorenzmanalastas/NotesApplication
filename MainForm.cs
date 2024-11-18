using NotesApplication.Controllers;
using NotesApplication.DAO;
using NotesApplication.Data;
using NotesApplication.Forms;
using NotesApplication.Models;
using NotesApplication.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotesApplication
{
    
    public partial class MainForm : Form
    {
        public readonly NotesController _notesController;
        public MainForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var notesRepository = new NotesRepository(context);
            var notesService = new NoteService(notesRepository);
            _notesController = new NotesController(notesService);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNotes_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm();
            addForm.NoteAdded += LoadNotes;
            addForm.ShowDialog();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNotes();
        }
        private void LoadNotes()
        {
            var notes = _notesController.GetAllNotes();
            notePanel.Controls.Clear();
            foreach (var note in notes)
            {
                AddNoteCard(note);
            }
        }
            private void AddNoteCard(NotesItem notesItem)
            {
                var cardPanel = new Panel
                {
                    Size = new Size(370, 160),
                    BackColor = Color.Beige,
                    Margin = new Padding(30),
                    Padding = new Padding(10)
                };

                // Delete Icon (Text-Based)
                var deleteIcon = new Label
                {
                    Text = "✖", // Unicode character for 'X' symbol
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.Red,
                    Cursor = Cursors.Hand,
                    Location = new Point(cardPanel.Width - 30, 5),
                    AutoSize = true
                };
                deleteIcon.Click += (sender, e) => DeleteNote(notesItem);
                cardPanel.Controls.Add(deleteIcon);

                var editIcon = new Label
                {
                    Text = "✏", // Unicode character for pencil
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    ForeColor = Color.Gold,
                    Cursor = Cursors.Hand,
                    Location = new Point(cardPanel.Width - 60, 5),
                    AutoSize = true
                };
                editIcon.Click += (sender, e) => UpdateNote(notesItem);
                cardPanel.Controls.Add(editIcon);

                var courseLabel = new Label
                {
                    Text = $"{notesItem.NoteTitle}",
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    ForeColor = Color.DarkSlateGray,
                    Location = new Point(10, 10),
                    AutoSize = true
                };
                cardPanel.Controls.Add(courseLabel);

                var nameLabel = new Label
                {
                    Text = $"{notesItem.NoteContent}",
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.DimGray,
                    Location = new Point(10, 35),
                    AutoSize = true
                };
                cardPanel.Controls.Add(nameLabel);


                var viewDetails = new LinkLabel
                {
                    Text = "View Details",
                    Font = new Font("Segoe UI", 9, FontStyle.Bold),
                    ForeColor = Color.Blue,
                    Location = new Point(20, 55),
                    AutoSize = true
                };
                // Calculate the position for bottom right corner
                viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
                viewDetails.LinkClicked += (sender, e) => ShowNoteDetails(notesItem);
                cardPanel.Controls.Add(viewDetails);

                notePanel.Controls.Add(cardPanel);
            }

            private void ShowNoteDetails(NotesItem noteItem)
            {
                MessageBox.Show(noteItem.NoteTitle);
            }

            private void UpdateNote(NotesItem noteItem)
            {
                // Logic to update the subject
                var updateNoteForm = new UpdateForm(noteItem);
                updateNoteForm.NoteUpdated += (updatedNote) =>
                {
                    // Update the specific note in the list immediately
                    LoadNotes(); // Reload all notes to reflect changes
                };
                //addNoteForm.NoteAdded += LoadNotes;
                updateNoteForm.ShowDialog();
            }

            private void DeleteNote(NotesItem noteItem)
            {
                var confirmResult = MessageBox.Show($"Are you sure to delete {noteItem.NoteTitle}?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _notesController.DeleteNote(noteItem.Id);
                    LoadNotes(); // Refresh the subjects list
                }

            }
        }
    }
