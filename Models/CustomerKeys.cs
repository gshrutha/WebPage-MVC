using System.ComponentModel.DataAnnotations;

namespace WebPage.Models
{
    public class CustomerKeys
    {
    [Key]
    public int KeyId { get; set; }
    public string Keyname { get; set; }
    public string CustomerName { get; set; } 

    }
}
