using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotesApplication.DAO;
using NotesApplication.Models;

namespace NotesApplication.Services
{
    public class NoteService
    {
        private readonly NotesRepository _notesRepository;
        public NoteService(NotesRepository notesRepository)
        {
            _notesRepository = notesRepository;
        }

        public List<NotesItem> GetAllNote()
        {
            return _notesRepository.GetAllNote();
        }
        public NotesItem GetNoteById(int id)
        {
            return _notesRepository.GetNoteById(id);
        }
        public void AddNote(NotesItem noteItem)
        {
            _notesRepository.AddNote(noteItem);
        }
        public void DeleteNote(int id)
        {
            _notesRepository.DeleteNote(id);
        }
        public void UpdateNote(NotesItem noteItem)
        {
            _notesRepository.UpdateNote(noteItem);
        }
    }
}
