
string alphabetString = "a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z";
string[] alphabet = alphabetString.Split(", "); //Creates a list where each index is a letter of the alphabet

foreach (String letter in alphabet){ //Iterates over the list assigning the index currently in use to the variable "letter"
    Console.WriteLine(letter);
}