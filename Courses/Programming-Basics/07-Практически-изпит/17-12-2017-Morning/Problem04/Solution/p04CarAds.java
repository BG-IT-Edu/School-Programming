package exam_car_lot;

import java.util.Scanner;

public class p04CarAds {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());
        int gasolineCarsCount = 0;
        int dieselCarsCount = 0;

        for (int i = 0; i < n; i++) {
            String carModel = console.nextLine();
            String carType = console.nextLine(); // coupe or sedan
            String fuelType = console.nextLine(); // gasoline or diesel
            String adStatus = console.nextLine(); // normal or vip
            double price = Double.parseDouble(console.nextLine());
            int kilometers = Integer.parseInt(console.nextLine());

            String category = "";


            if (carType.toLowerCase().equals("coupe")){
                if (fuelType.toLowerCase().equals("gasoline")){
                    category = "sport";
                    if (price > 100000){
                        category = "supersport";
                    }
                    gasolineCarsCount++;

                }else {
                    category = "ecosport";
                    dieselCarsCount++;
                }
            }else {
                if (fuelType.toLowerCase().equals("gasoline")){
                    category = "executive";
                    if (price > 80000){
                        category = "limousine";
                    }
                    gasolineCarsCount++;

                }else {
                    category = "economic";
                    dieselCarsCount++;
                }
            }

            if (adStatus.toLowerCase().equals("vip")){
                price += 200;
            }

            System.out.printf("Car model - %s%n", carModel);
            System.out.printf("Category - %s%n", category);
            System.out.printf("Type - %s%n", carType);
            System.out.printf("Fuel - %s%n", fuelType);
            System.out.printf("Kilometers - %d%n", kilometers);
            System.out.printf("Price - %.2f%n", price);

        }

        System.out.printf("Gasoline cars: %.2f%%%n", ((double)gasolineCarsCount / n) * 100);
        System.out.printf("Diesel cars: %.2f%%%n", ((double)dieselCarsCount / n) * 100);

    }
}
