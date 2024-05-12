namespace HomeWork3_6_4; 
public static class IntArrayExtension {
    public static void SortAscending(this int[] value) {
        for (int i = 0; i < value.Length - 1; i++) {
            for (int j = i+1; j < value.Length; j++) {
                if (value[i] > value[j]) {
                    var tmp = value[j]; 
                    value[j] = value[i];
                    value[i] = tmp;
                }
            }
        }
    }
    public static void ToConsole(this int[] value) {
        for (int i = 0; i < value.Length; i++) {
            Console.Write($"{value[i]} ");
        }
    }
}
