using UnityEngine;

// Literal (��) : 
public class Literal : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        //[1] ���� �����
        int num;    //������ ����    num = 1234;
        double su;  //�Ǽ��� ����    su = 3.14159;
        bool flag;  //�ο��� ����    trueȤ�� false������ 
        string str; //���ڿ� ����    str = "Hello!";
        char c;     //������ ����    c = 'a';

        sbyte iSbyte  	//8��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 	//16��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32  	//32��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 	 //64��Ʈ ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        byte iByte  	//8��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ        0-255
        ushort iUInt16 	//16��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ       0-65535 
        uint iUInt32  	//32��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ       0-4,294,967,295
        ulong iUInt64 	 //64��Ʈ ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ      0-18,446,744,073,709,551,615

        Debug.Log("Message: "+ message);  //[1] "Message: "+ message ���ڿ� ���ϱ� ����
        Debug.Log($"Message: {message}"); //[2] $"Message: {message}"���ڿ� ���������� ���

        gettype: ������ Ÿ�� �о����

        Var : �Ͻ������� ����ȭ�� ���� ����
        var ����� ������ �ʱ�ȭ�� �ݵ�� �Ѵ�  (���� Ű)


         string strNumber = "1234";

        int number1 = System.Convert.ToInt32(strNumber);
        Debug.Log($"{number1}-{number1.GetType()}");

        int number2 = int.Parse(strNumber);
        Debug.Log($"{number2}-{number2.GetType()}");

        int number3 = System.Int32.Parse(strNumber);
        Debug.Log($"{number3}-{number3.GetType()}");

         //�ڸ� �ٲٱ�
        temp = i;   //�ӽú��� (temp) �� i �� ���� 
        i = j;      //i ������ j �� ����
        j = temp;   //j ������ �ӽú����� ����Ǿ��� i���� ����

        int num =10;
        ++num;
        num--;

        //Relational Operator(������ ������, �� ������) :
        < (����), <=(�۰ų� ����),  > (ŭ), >=(ũ�ų� ����), ==(����), !=(�ٸ�) 
        ��� : true(��) / false(����) 

        int x=5;
        int y=9;
        Debug.Log(x<y);  => true
        NotLogical (���� ������, Not) : ! ���̸� �����̰�, �����̸� ������ ��ȯ

        OrOperator(Or������): || �ϳ��� ���̸� �� 
        andoperator(And������ ): And (&&) �Ѵ� ���϶��� ��
        ��� :true , false 

        if�� - ���ǹ� 
���ǽ��� ���϶��� ���๮�� ����˴ϴ�.
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�.

//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶� 
if(���ǽ�)
{
//���๮1
//���๮2
//���๮3
....
}







        */
    }
}
