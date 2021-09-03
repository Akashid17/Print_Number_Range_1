
#include<stdio.h>

void DisplayRange(int iNo1, int iNo2)
{
    if(iNo1 > iNo2)
    {
        printf("Invalid Range\n");
        return;
    }

    for(int i = iNo1; i <= iNo2; i++)
    {
        printf("%d ",i);
    }
    printf("\n");
}

int main()
{
    int iValue1 = 0, iValue2 = 0;

    printf("Enter First Number\n");
    scanf("%d",&iValue1);

    printf("Enter Second Number\n");
    scanf("%d",&iValue2);

    DisplayRange(iValue1,iValue2); 

    return 0;
}