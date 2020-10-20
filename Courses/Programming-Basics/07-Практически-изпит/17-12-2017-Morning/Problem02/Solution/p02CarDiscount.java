package exam_car_lot;

import java.util.Scanner;

public class p02CarDiscount {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String carModel = console.nextLine();
        int vinNumber = Integer.parseInt(console.nextLine());
        String condition = console.nextLine().toLowerCase();
        double priceOfCar = Double.parseDouble(console.nextLine());

        double profit = priceOfCar * 0.15;

        boolean isGoodCondition = false;
        boolean isCorrectVin = false;
        boolean canMakeDiscount = false;



        if (condition.toLowerCase().equals("good")){
            isGoodCondition = true;
        }

        if (vinNumber < 90000 && vinNumber % 2 == 0) {
            isCorrectVin = true;
        }

        if (profit > 400){
            canMakeDiscount = true;
        }


        if (isGoodCondition && isCorrectVin && canMakeDiscount){
            System.out.println("yes - " + carModel);
            System.out.printf("profit - %.2f%n", profit);
        }else {
            System.out.println("no");
            if (!isGoodCondition) {
                System.out.println("The car is in bad condition");
            }
            if (!isCorrectVin) {
                System.out.println("VIN " + vinNumber + " is not valid");
            }
            if (!canMakeDiscount){
                System.out.printf("Cannot make discount, profit too low - %.2f%n", profit);
            }
        }

    }
}
