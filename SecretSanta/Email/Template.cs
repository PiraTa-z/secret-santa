using SecretSanta.Participants;
using System.Collections.Generic;

namespace SecretSanta.Email
{
    internal static class Template
    {
        public static string Get(KeyValuePair<Participant, Participant> pair)
        {
            return "<body style='background:#8DCCEB!important; margin:0; font-family: Georgia, Times, serif; color:#298EC6; font-size: 16px;'>" +
            "<div style='background:#8DCCEB; padding:20px 10px 40px; min-width:440px'>" +
                "<div style='width: 400px; background: #F1F1E5; margin:20px auto; padding: 10px 20px 20px; -webkit-border-radius: 10px; -moz-border-radius: 10px; border-radius: 10px; -webkit-box-shadow: 0 4px 10px rgba(0,0,0,.4); -moz-box-shadow: 0 4px 10px rgba(0,0,0,.4); box-shadow: 0 4px 10px rgba(0,0,0,.4);'>" +
                "<center>" +
                "<h2 style='color:#E22428;font-family: Georgia, Times, serif;'>Secret Santa 2020</h2>" +
                " </center>" +
                " <div style='background: #fff; margin:20px auto; padding: 10px 20px 20px; -webkit-border-radius: 10px; -moz-border-radius: 10px; border-radius: 10px;'>" +
                        "<center><h3 style='font-family: Georgia, Times, serif;color:#5BA0C7;'>გამარჯობა, " + pair.Key.Name.Split(" ")[0] + "!</h3></center>" +
                        "<em style='font-family: Georgia, Times, serif; color:#298EC6;'>" +
                        "<p>ჯადოსნური ახალი წელი ახლოვდება <3</p>" +
                      "<p>ძვირფასო სანტა, ყველაზე ლამაზი, მხიარული და ბედნიერი დღესასწაულის შექმნა წელსაც შენს ხელთაა.</p>" +
                      "<p>შექუმენი დადებითი განწყობა და გაახარე შენი ადრესატი:</p>" +
                      "</em>" +
                      "<center><h1 style='color:#E22428;'><em>" + pair.Value.Name + "<em></h1></center>" +
                      "<p>ერთად მოვიყვანოთ ყველაზე თბილი ახალი წელი</p>" +
                      "<center>ჰოუ ჰოუ ჰოუ! :)</center>" +
                      "</div>" +
                      "</div>" +
                      "</div>" +
                      "</body>";
        }
    }
}
