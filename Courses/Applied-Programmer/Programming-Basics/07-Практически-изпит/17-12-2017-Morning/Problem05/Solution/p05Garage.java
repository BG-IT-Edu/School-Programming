package exam_car_lot;

import java.util.Scanner;

public class p05Garage {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);

        int n = Integer.parseInt(console.nextLine());
        int width = 2 * n + 2;


        System.out.println(repeatStr("|", width));
        System.out.println(repeatStr("+", width));

        int sideSpaceCount = width / 2;

        System.out.println(repeatStr("|", sideSpaceCount - 3) + "GARAGE"
                         + repeatStr("|", sideSpaceCount - 3));

        for (int i = 0; i < n-2; i++) {
             if (i >= (n-2) - 2){ // Last 2 rows
                 System.out.println("|"
                         +repeatStr("/", n - 3) + "|    |"
                         + repeatStr("\\", n - 3) + "|");
             }else {
                 System.out.println(repeatStr("|",width ));
             }
        }


        System.out.println(repeatStr(" ", n - 2) + "/////");
    }


    private static String repeatStr(String str, int count){
        String result = "";
        for (int i = 0; i < count; i++) {
            result += str;
        }
        return result;
    }
}
