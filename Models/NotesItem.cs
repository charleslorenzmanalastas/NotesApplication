using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace NotesApplication.Models
{
    public class NotesItem
    {
        [Key]
        public int Id { get; set; }
        public string NoteTitle { get; set; }
        public string NoteContent { get; set; }
        public DateTime Date { get; set; }
    }
}
