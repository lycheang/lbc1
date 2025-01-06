import java.util.Scanner;

public class aub {
    public static void main(String[] args) {
        Scanner sc= new Scanner(System.in);
        int n;
        int sum=0;
        System.out.println("number of n:");
        n=sc.nextInt();
        for (int i=1;i<=n;i++){
            if(i%2!=0)
            {
                sum+=i;
                
            }
            else{

            }
            
        }
        System.out.println("Sum of odd:"+sum);
    }
}
