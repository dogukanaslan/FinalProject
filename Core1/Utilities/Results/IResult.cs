using System;
using System.Collections.Generic;
using System.Text;

namespace Core1.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}

//Sadece get olduğu için productmanagerda metotta return kullanmamız lazım.
//Ama Getterlar(get) read only dir ve constructor içinde set edilebilirler.
//Set etmememizin nedeni yazılımcıyı kısıtlamak ve kodları standart hale getirmektir bundan dolatı constructor içinde set yaparız.
