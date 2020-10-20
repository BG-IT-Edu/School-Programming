package exam_car_lot;

import java.util.Scanner;

public class p01ResellProfit {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        String carModel = console.nextLine();
        double initialCarPrice = Double.parseDouble(console.nextLine());
        int daysStayedInTheLot = Integer.parseInt(console.nextLine());


        double additionalExpenses = (initialCarPrice * 0.2) + 275; // 20% tax + 275 flat tax
        double carPriceWithExpenses =
                initialCarPrice + additionalExpenses + (daysStayedInTheLot * 20); // 20 per day

        double profit = carPriceWithExpenses * 0.15; // We want 15% profit


        System.out.printf("The %s with initial price of %.2f BGN will sell for %.2f BGN%n",
                carModel, initialCarPrice, carPriceWithExpenses + profit);


        System.out.printf("Profit: %.2f BGN%n", profit);
    }
}
