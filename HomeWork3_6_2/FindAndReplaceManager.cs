namespace HomeWork3_6_2;

public static class FindAndReplaceManager {

    public static Book Book { get; set; }
    public static bool FindNext (string str) {
        return Book.FindNext (str);
    }
}
