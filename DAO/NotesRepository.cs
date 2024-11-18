using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApplication.Data;
using NotesApplication.Models;

namespace NotesApplication.DAO
{
    public class NotesRepository
    {
        private readonly ApplicationDbContext _context;

        public NotesRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<NotesItem> GetAllNote()
        {
            return _context.NoteItems.ToList();
        }

        public NotesItem GetNoteById(int id)
        {
            return _context.NoteItems.Find(id);
        }

        public void AddNote(NotesItem noteItem)
        {
            _context.NoteItems.Add(noteItem);
            _context.SaveChanges();
        }
        public void UpdateNote(NotesItem noteItem)
        {
            _context.NoteItems.Update(noteItem);
            _context.SaveChanges();
        }
        public void DeleteNote(int id)
        {
            var note = _context.NoteItems.Find(id);
            if (note != null)
            {
                _context.NoteItems.Remove(note);
                _context.SaveChanges();
            }
        }
    }
}
