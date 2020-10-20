package crypto_exam;

import java.util.Scanner;

public class p06GenerateCodes {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        long passCode = Long.parseLong(console.nextLine());
        int codesWanted = Integer.parseInt(console.nextLine());

        int count = 0;

        for (int i = 0; i <= 9; i++) {
            for (int j = 0; j <= 9; j++) {
                for (int k = 0; k <= 9; k++) {
                    for (char l = 'a'; l <= 'z'; l++) {
                        for (char m = 'a'; m <='z'; m++) {
                            for (int n = 0; n <= 9; n++) {


                                if (i + j + k + l + m + n == passCode) {
                                    System.out.print("" + i + j + k + l + m + n + " ");
                                    count++;
                                }

                                if (count == codesWanted){
                                    return;
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
