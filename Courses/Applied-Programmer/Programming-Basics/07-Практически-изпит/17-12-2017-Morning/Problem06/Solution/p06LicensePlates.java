package exam_car_lot;

import java.util.Scanner;

public class p06LicensePlates {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String firstPart = console.nextLine();
        String lastPart = console.nextLine();
        int platesWanted = Integer.parseInt(console.nextLine());


        int counter = 0;

        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                for (int k = 0; k < 10; k++) {
                    for (int l = 0; l < 10; l++) {

                        if (counter < platesWanted){
                            if (i + j + k + l == (i * k) - platesWanted){
                                System.out.print(firstPart + i +j + k + l + lastPart + " ");
                                counter++;
                            }
                        }

                    }
                }
            }
        }



    }
}
