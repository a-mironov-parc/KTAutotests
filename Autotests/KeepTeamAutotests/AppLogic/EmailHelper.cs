using KeepTeamAutotests.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageMagick;
using KeepTeamAutotests.Pages;
using Newtonsoft.Json;
using System.IO;
using LumiSoft.Net.IMAP;
using LumiSoft.Net.IMAP.Client;
using LumiSoft.Net;


namespace KeepTeamAutotests.AppLogic
{
    public class EmailHelper
    {
        public EmailHelper(AppManager app)
            
        {
          
        }
        public void connect()
        {
            IMAP_Client client = new IMAP_Client();
            client.Connect("imap.yandex.ru", 995, true);
            client.Login("testkeepteam1", "testmail");
            client.SelectFolder("Inbox");
            
        /*    client
            client.Fetch(false, 
                     IMAP_t_SeqSet.Parse("2:1"), 
                     new IMAP_t_Fetch_i() {new IMAP_t_Fetch_i_Envelope()}, 
                     new EventHandler(Of LumiSoft.Net.EventArgs(Of IMAP_r_u))(AddressOf client_Fetch));

   */
        }
        public IMAP_Client loginAs(string login, string password)
        {
            IMAP_Client client = new IMAP_Client();
            client.Connect("imap.yandex.ru", 993, true);
            client.Login(login, password);
            client.SelectFolder("INBOX");
            Console.Out.WriteLine("метод loginAS");
            return client;
          
        }
        public void getEmail(string login, string password)
        {
            IMAP_Client client = new IMAP_Client();
            client.Connect("imap.yandex.ru", 993, true);
            client.Login(login, password);
            client.SelectFolder("INBOX");

            IMAP_SequenceSet sequence = new IMAP_SequenceSet();
            //sequence.Parse("*:1"); // from first to last
            IMAP_Client_FetchHandler fetchHandler = new IMAP_Client_FetchHandler();

            fetchHandler.NextMessage += new EventHandler(delegate(object s, EventArgs e)
            {
                Console.WriteLine("next message");
            });

            fetchHandler.Envelope += new EventHandler<EventArgs<IMAP_Envelope>>(delegate(object s, EventArgs<IMAP_Envelope> e)
            {
                IMAP_Envelope envelope = e.Value;
                if (envelope.From != null && !String.IsNullOrWhiteSpace(envelope.Subject))
                {
                    Console.WriteLine(envelope.Subject);
                }
            });
            // the best way to find unread emails is to perform server search
            int[] unseen_ids = client.Search(false, "UTF-8", "unseen");
            Console.WriteLine("unseen count: " + unseen_ids.Count().ToString());
            // now we need to initiate our sequence of messages to be fetched
            sequence.Parse(string.Join(",", unseen_ids));
            // fetch messages now
            client.Fetch(false, sequence, new IMAP_Fetch_DataItem[] { new IMAP_Fetch_DataItem_Envelope() }, fetchHandler);
            // uncomment this line to mark messages as read
            // client.StoreMessageFlags(false, sequence, IMAP_Flags_SetType.Add, IMAP_MessageFlags.Seen);
            
        }

        public void DeleteCurrentMessage()
        {
            //throw new NotImplementedException();
        }

        public bool TimeOffEmail()
        {
            return false;//throw new NotImplementedException();
        }
    }
}
