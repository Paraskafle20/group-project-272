using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace group_project.Models
{
    public class RegisterViewModel
    { [Required(ErrorMessage = "Full name is required.")] 
        public string FullName { get; set; } 
        [Required(ErrorMessage = "Contact number is required.")] public string ContactNumber { get; set; } }
        public class Person
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        // Navigation property
        public ICollection<Borrowing> Borrowings { get; set; }
        // Other properties
    }

    public class Book
    {
        public int ISBN { get; set; }

        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        // Navigation property
        public ICollection<Borrowing> Borrowings { get; set; }
        // Other properties
    }
    public class Borrowing
    {
        public int BorrowingId { get; set; }


        public int PersonId { get; set; }
        public int BookId { get; set; }
        [Display(Name = "Borrow Date")]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime BorrowDate { get; set; }

        [Display(Name = "Return Date")]
        public DateTime? ReturnDate { get; set; }

        // Navigation properties
        public virtual Person Person { get; set; }
        public virtual Book Book { get; set; }
    }

    public class BookType
    {
        public int BookTypeId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Type Name")]
        public string TypeName { get; set; }

        // Navigation property
        public virtual ICollection<Book> Books { get; set; }
    }
}