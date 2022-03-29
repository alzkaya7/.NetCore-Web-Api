using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nlayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T Data { get; set; }

        [JsonIgnore] //Json olarak ignore et  ..
        public int StatusCode { get; set; }
        public List<string> Errors { get; set; }



        //geriye Succes olduğunda , durum kodunu ve T datasını alan bi method yazıldı ..
        public static CustomResponseDto<T> Success(int statusCode, T data)

        {

            return new CustomResponseDto<T> { StatusCode = statusCode, Data = data };

        }


        public static CustomResponseDto<T> Success(int statusCode)

        {

            return new CustomResponseDto<T> { StatusCode = statusCode };

        }

        //Hata durumunda ele alınacak  .. Bir durum kodu ve Hata Mesajı na ihityacım var  .. birden fazla hatam olabir o yüzden list şeklinde tanımladık ..
        public static CustomResponseDto<T> Fail(int statusCode, List<string> ErrorMessage)

        {

            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = ErrorMessage };

        }
        //Tek bir hatam olması durumunda olacak durm.. Tek bir hatam dahi olsa bunu dizi şekilinde dörceii için list e eşitledik..
        public static CustomResponseDto<T> Fail(int statusCode, string error)

        {

            return new CustomResponseDto<T> { StatusCode = statusCode, Errors = new List<string> { error } };

        }



    }
}
