package exam_car_lot;

import java.util.Scanner;

public class p03SeasonSale {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String carModel = console.nextLine();
        String carType = console.nextLine().toLowerCase(); //sedan or suv
        String season = console.nextLine().toLowerCase(); //winter or summer
        String condition = console.nextLine().toLowerCase(); //perfect, good or bad
        double initialPrice = Double.parseDouble(console.nextLine());
        double profitWanted = Double.parseDouble(console.nextLine());

        double profit = 0.0;

            if (carType.equals("suv")){
                if (condition.equals("perfect")){
                    profit = initialPrice * 0.3; //perfect condition suv
                }else if (condition.equals("good")){
                    profit = initialPrice * 0.2; // good condition suv
                }else {
                    profit = initialPrice * 0.1; // bad condition suv
                }
            }else {
            if (condition.equals("perfect")){
                profit = initialPrice * 0.25; //perfect condition sedan
            }else if (condition.equals("good")){
                profit = initialPrice * 0.15; // good condition sedan
            } else {
                profit = initialPrice * 0.10; // bad condition sedan
            }
            }

            if (season.equals("winter")){
                profit -= 200; // winter tires
            }


            if (profit >= profitWanted){
                System.out.printf("The profit on %s will be good - %.2f BGN%n", carModel, profit);
            }else{
                System.out.println("The car is not worth selling now");
                System.out.printf("Need %.2f more profit%n", profitWanted - profit);
            }




    }
}
