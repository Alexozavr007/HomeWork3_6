
namespace HomeWork3_6_3; 
public class Book {
    public Notes[] NotesCollection {  get; set; }
    public Book(params Notes[] notes) { 
        NotesCollection = notes;
    }

    public class Notes {
        public string Text { get; set; }

        public Notes(string text) {
            Text = text;
        }
   }
}
