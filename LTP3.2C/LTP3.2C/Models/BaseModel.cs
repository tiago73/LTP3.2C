using System;
using System.ComponentModel.DataAnnotations;

namespace LTP3._2C.Models
{
    public class BaseModel
    {
        public BaseModel()
        {
            Id = new Guid();
        }
        [Key]
        public Guid Id { get; set; }
    }
}
