using UnityEngine;

public class SignedIngeger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        //SignedIngeger
        sbyte iSbyte = 127; //8비트 부호가 있는 정수형 변수 선언 및 초기화
        short iInt16 = 32767; //16비트 부호가 있는 정수형 변수 선언 및 초기화
        int iInt32 = 2147483647; //32비트 부호가 있는 정수형 변수 선언 및 초기화
        long iInt64 = 9223372036854775807; //64비트 부호가 있는 정수형 변수 선언 및 초기화

        Debug.Log("sbyte:"+ iSbyte);
        Debug.Log("short:" + iInt16);
        Debug.Log("int:" + iInt32);
        Debug.Log("long:" + iInt64);

        //UnSignedIngeger
        byte iByte = 255; //8비트 부호가 없는 정수형 변수 선언 및 초기화
        ushort iUInt16 = 65535; //16비트 부호가 없는 정수형 변수 선언 및 초기화
        uint iUInt32 = 4294967295; //32비트 부호가 없는 정수형 변수 선언 및 초기화
        ulong iUInt64 = 18446744073709551615;//64비트 부호가 없는 정수형 변수 선언 및 초기화

        Debug.Log("byte:" + iByte);
        Debug.Log("ushort:" + iUInt16);
        Debug.Log("uint:" + iUInt32);
        Debug.Log("ulong:" + iUInt64);

    }
}

/*
1 Bit   (0,1)

1 Byte  : 8 bit  (0000 0000)
2진수 (0,1); 8진수 (1~7); 16진수 (1~F)

8bit
(+, -, 0)
sbyte   : -128 ~ 127

(+, 0)
byte    : 0 ~ 255


1 KiloByte  : 1024 B 
1 MegaByte  : 1024 KB
1 GigaByte  : 1024 MB
1 TeraByte  : 1024 GB
1 PetaByte  : 1024 TB
*/


/*
SignedIngeger (+, -, 0) 부호가 있는 정수형 데이터 형식(타입)
UnSignedIngeger (+,0) 부호가 없는 정수형 데이터 형식(타입) 마이너스를 기록하지않은 데이터 형식
*/