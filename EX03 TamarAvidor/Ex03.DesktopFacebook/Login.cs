namespace Ex01.DesktopFacebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using FacebookWrapper;

    public static class Login
    {
        public static LoginResult login()
        {
            /// Owner: design.patterns
            /// User: design.patterns
            /// 
            LoginResult result = FacebookService.Connect("CAADIb3irsWkBAN1I4905XLZAViQ1IL4wn3mYDX9w3ALE7WLc2bGCBzYHZC1hRarqLU0bLgW57CfcE7QXVonoqieHB4tYNSUCvwkUPcLEECoy8OSY43tRQRJLzeDw2bmKrEOyor7rmFSMtWQMUL3T1HCqZCRorkZD");

            /*LoginResult result = FacebookService.Login("220381091443049", // Demo (design.patterns)
                "user_about_me", "friends_about_me", "publish_stream", "user_events", "read_stream",
                "user_status", "friends_events", "rsvp_event", "user_photos" // this is instead of the 'user_checkins' permission, as desricbed here: http://developers.facebook.com/bugs/170251059758531
                );*/

            return result;
        }
    }
}
