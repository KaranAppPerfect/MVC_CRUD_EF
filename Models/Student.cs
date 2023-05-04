using System.ComponentModel.DataAnnotations.Schema;

namespace StudentCrudApp.Models
{

    public class Student{

            [Column("studentid")] 
            public int StudentId{get; set;}

            [Column("name")] 
            public string Name{get; set;} = null!;


            [Column("email")] 
            public string Email{get; set;} = null!;

            [Column("branch")] 
            public Branch Branch{get; set;}

            [Column("gender")] 
            public Gender Gender{get; set;}

            [Column("address")] 
            public string Address{get; set;} = null!;

            [NotMapped]
            public IEnumerable<Gender>? AllGenders { set; get; }

    }



}