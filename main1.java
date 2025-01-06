import java.util.Scanner;

public class main1 {
    public static void main(String[] args) {
        Sumoddvalue();
        
    }
    static int sumOddvalue(int a,int b){
        int result=0;
        for(int i=a;i<=b;i++){
            if(i%2!=0){
                result+=i;
            }

        }
        return result;
    }
    static void Sumoddvalue(){
        Scanner scan= new Scanner(System.in);
        int sum=0;
        int n;
System.out.println("Enter number n:");
n=scan.nextInt();
        for (int i=1;i<=n;i++){
            if(i%2!=0){
                sum+=i;
            }
            
        }
        System.out.println("Sum of odd:"+sum);
    }
}
