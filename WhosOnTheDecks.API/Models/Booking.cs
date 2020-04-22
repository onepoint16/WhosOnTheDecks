using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhosOnTheDecks.API.Models
{
    //Bookings class is used to make a booking object
    //A booking is made to hire a DJ
    //Booking is tied to a single event and a single DJ
    public class Booking
    {
        //Primary Key for class
        //integer BookingId used to store a unique ID
        [Key]
        public int BookingId { get; set; }

        //Date time Start time to indicate the start if the DJs performance
        [Required]
        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime StartTime { get; set; }

        //Date time End time to indicate the end fo the DJ's performance
        [Required]
        [Display(Name = "End Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}")]
        public DateTime EndTime { get; set; }

        //Boolean Bookingstatus to indicate weither the booking is Active or Cancelled
        [Required]
        [Display(Name = "Booking Status")]
        public bool BookingStatus { get; set; }

        //Navigational Property
        //Links Booking to a single DJ
        [ForeignKey("Dj")]
        public int DjId { get; set; }
        public Dj Dj { get; set; }

        //Navigational Property
        //Links Booking to a single Event
        [ForeignKey("Event")]
        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}