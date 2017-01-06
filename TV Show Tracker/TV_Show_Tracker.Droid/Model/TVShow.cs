using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Newtonsoft.Json;

namespace TV_Show_Tracker.Droid.Model
{

    //TODO: Implement the model for the data returned when user searches for TV show
    // at the moment, data is returned successfully
    // "[{\"score\":11.6426735,\"show\":
    //{\"id\":139,\"url\":\"http://www.tvmaze.com/shows/139/girls\",
    //\"name\":\"Girls\",\"type\":\"Scripted\",\"language\":\"English\",\"genres\":[\"Drama\",\"Romance\"],
    //\"status\":\"Running\",\"runtime\":30,\"premiered\":\"2012-04-15\",
    //\"schedule\":{\"time\":\"22:00\",\"days\":[\"Sunday\"]},
    //\"rating\":{\"average\":6.4},\"weight\":2,\"network\":{\"id\":8,
    //\"name\":\"HBO\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":
    //\"America/New_York\"}},\"webChannel\":null,\"externals\":
    //{\"tvrage\":30124,\"thetvdb\":220411,\"imdb\":\"tt1723816\"},\"image\":
    //{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/31/78286.jpg\",
    //\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/31/78286.jpg\"},
    //\"summary\":\"<p>This Emmy winning series is a comic look at the assorted humiliations and rare triumphs of a group of girls in their 20s.</p>\",\"updated\":1481346596,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/139\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/621947\"},\"nextepisode\":{\"href\":\"http://api.tvmaze.com/episodes/840746\"}}}},{\"score\":8.84298,\"show\":{\"id\":23734,\"url\":\"http://www.tvmaze.com/shows/23734/tattoo-girls\",\"name\":\"Tattoo Girls\",\"type\":\"Reality\",\"language\":\"English\",\"genres\":[],\"status\":\"In Development\",\"runtime\":null,\"premiered\":\"2017-01-24\",\"schedule\":{\"time\":\"22:00\",\"days\":[\"Tuesday\"]},\"rating\":{\"average\":null},\"weight\":3,\"network\":{\"id\":80,\"name\":\"TLC\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":null,\"thetvdb\":null,\"imdb\":null},\"image\":null,\"summary\":\"<p><strong>Tattoo Girls </strong>is set against the backdrop of Ink Ink, a tattoo shop like no other—an all-female lineup of tattoo artists.</p>\",\"updated\":1483309330,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/23734\"},\"nextepisode\":{\"href\":\"http://api.tvmaze.com/episodes/1016761\"}}}},{\"score\":8.841106,\"show\":{\"id\":525,\"url\":\"http://www.tvmaze.com/shows/525/gilmore-girls\",\"name\":\"Gilmore Girls\",\"type\":\"Scripted\",\"language\":\"English\",\"genres\":[\"Drama\",\"Comedy\",\"Romance\"],\"status\":\"Ended\",\"runtime\":60,\"premiered\":\"2000-10-05\",\"schedule\":{\"time\":\"21:00\",\"days\":[\"Tuesday\"]},\"rating\":{\"average\":8.8},\"weight\":1,\"network\":{\"id\":5,\"name\":\"The CW\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":3683,\"thetvdb\":76568,\"imdb\":\"tt0238784\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/4/11308.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/4/11308.jpg\"},\"summary\":\"<p><strong>Gilmore Girls</strong> is a drama centering around the relationship between a thirtysomething single mother and her teen daughter living in Stars Hollow, Connecticut.</p>\",\"updated\":1483406259,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/525\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/47639\"}}}},{\"score\":8.814844,\"show\":{\"id\":6771,\"url\":\"http://www.tvmaze.com/shows/6771/the-powerpuff-girls\",\"name\":\"The Powerpuff Girls\",\"type\":\"Animation\",\"language\":\"English\",\"genres\":[\"Comedy\"],\"status\":\"Running\",\"runtime\":15,\"premiered\":\"2016-04-04\",\"schedule\":{\"time\":\"17:00\",\"days\":[\"Monday\",\"Tuesday\",\"Wednesday\",\"Thursday\",\"Friday\"]},\"rating\":{\"average\":5.5},\"weight\":0,\"network\":{\"id\":11,\"name\":\"Cartoon Network\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":null,\"thetvdb\":307473,\"imdb\":\"tt4718304\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/25/64201.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/25/64201.jpg\"},\"summary\":\"<p>The city of Townsville may be a beautiful, bustling metropolis, but \\ndon't be fooled! There's evil afoot! And only three things can keep the \\nbad guys at bay: Blossom, Bubbles and Buttercup, three super-powered \\nlittle girls, known to their fans (and villains everywhere) as <strong>The \\nPowerpuff Girls</strong>. Juggling school, bedtimes, and beating up giant \\nmonsters may be daunting, but together the Powerpuff Girls are up to the\\n task. Battling a who's who of evil, they show what it really means to \\n\\\"fight like a girl.\\\"</p>\",\"updated\":1483004734,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/6771\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/998421\"}}}},{\"score\":8.801692,\"show\":{\"id\":24140,\"url\":\"http://www.tvmaze.com/shows/24140/sky-girls\",\"name\":\"Sky Girls\",\"type\":\"Animation\",\"language\":\"Japanese\",\"genres\":[\"Anime\",\"Science-Fiction\"],\"status\":\"Ended\",\"runtime\":30,\"premiered\":\"2007-07-05\",\"schedule\":{\"time\":\"01:28\",\"days\":[\"Thursday\"]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":475,\"name\":\"TV Aichi\",\"country\":{\"name\":\"Japan\",\"code\":\"JP\",\"timezone\":\"Asia/Tokyo\"}},\"webChannel\":null,\"externals\":{\"tvrage\":null,\"thetvdb\":81428,\"imdb\":\"tt1094233\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/91/228897.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/91/228897.jpg\"},\"summary\":\"<p>The story takes place in a time when a third of mankind was wiped out by an enemy known as Worms. Mankind had to resort to using weapons of mass destruction to win. But 10 years later, Worms had return. The name Sky Girls refers to the special few girls who pilot large mechanical frames called Sonic Divers into battle.</p>\",\"updated\":1483390963,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/24140\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/1029412\"}}}},{\"score\":8.795076,\"show\":{\"id\":7108,\"url\":\"http://www.tvmaze.com/shows/7108/mohawk-girls\",\"name\":\"Mohawk Girls\",\"type\":\"Scripted\",\"language\":\"English\",\"genres\":[\"Drama\",\"Comedy\",\"Romance\"],\"status\":\"Running\",\"runtime\":30,\"premiered\":\"2014-11-23\",\"schedule\":{\"time\":\"21:00\",\"days\":[\"Sunday\"]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":480,\"name\":\"OMNI\",\"country\":{\"name\":\"Canada\",\"code\":\"CA\",\"timezone\":\"Canada/Atlantic\"}},\"webChannel\":null,\"externals\":{\"tvrage\":46333,\"thetvdb\":288643,\"imdb\":\"tt1755606\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/26/66494.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/26/66494.jpg\"},\"summary\":\"<p>Finding love is hard. Finding yourself is even harder. Especially when \\nyour family, friends and everyone in town has an opinion. Mohawk Girls \\nis a comedic look at the lives of four modern-day women trying to stay \\ntrue to their roots while they navigate sex, work, sex, love, sex and \\nthe occasional throw down.</p>\",\"updated\":1446084660,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/7108\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/408206\"}}}},{\"score\":8.794231,\"show\":{\"id\":9148,\"url\":\"http://www.tvmaze.com/shows/9148/gallery-girls\",\"name\":\"Gallery Girls\",\"type\":\"Reality\",\"language\":\"English\",\"genres\":[],\"status\":\"Ended\",\"runtime\":60,\"premiered\":\"2012-08-13\",\"schedule\":{\"time\":\"22:00\",\"days\":[\"Monday\"]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":52,\"name\":\"Bravo\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":32045,\"thetvdb\":259240,\"imdb\":\"tt1885780\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/32/80675.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/32/80675.jpg\"},\"summary\":\"<p>Bravo's <em>Gallery Girls</em> is a docu-series that follows the lives of seven dynamic and ambitious young women in New York City who tackle the cutthroat environment of the art world while vying for their dream jobs. From gallery openings and art shows to the hottest events in the city, the women share a passion for art -- but are divided between their Manhattan and Brooklyn lifestyles with vastly different views and tastes towards fashion, art, and men. Attempting to juggle a chic and fabulous standard of living, the ladies tackle financial struggles, family issues, and the pressures of jump starting their lives in the city that never sleeps.</p>\",\"updated\":1448639246,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/9148\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/494985\"}}}},{\"score\":8.794171,\"show\":{\"id\":23542,\"url\":\"http://www.tvmaze.com/shows/23542/good-girls\",\"name\":\"Good Girls\",\"type\":\"Scripted\",\"language\":\"English\",\"genres\":[\"Drama\",\"Crime\"],\"status\":\"In Development\",\"runtime\":60,\"premiered\":null,\"schedule\":{\"time\":\"\",\"days\":[]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":1,\"name\":\"NBC\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":null,\"thetvdb\":null,\"imdb\":null},\"image\":null,\"summary\":\"<p><strong>Good Girls</strong> is a suburban Crime Drama from Jenna Bans.</p>\",\"updated\":1481307286,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/23542\"}}}},{\"score\":8.792725,\"show\":{\"id\":7349,\"url\":\"http://www.tvmaze.com/shows/7349/gotham-girls\",\"name\":\"Gotham Girls\",\"type\":\"Animation\",\"language\":\"English\",\"genres\":[\"Comedy\",\"Children\",\"Science-Fiction\"],\"status\":\"Ended\",\"runtime\":30,\"premiered\":\"2000-07-27\",\"schedule\":{\"time\":\"\",\"days\":[]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":71,\"name\":\"The WB\",\"country\":{\"name\":\"United States\",\"code\":\"US\",\"timezone\":\"America/New_York\"}},\"webChannel\":null,\"externals\":{\"tvrage\":31712,\"thetvdb\":79390,\"imdb\":null},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/27/67814.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/27/67814.jpg\"},\"summary\":\"<p><strong>Gotham Girls</strong>, an online Flash-animated series, debuted on July 27th, 2000, spotlighting Batgirl, Harley Quinn, Poison Ivy, Catwoman and other female Gothamites. If you've never checked out the Gotham Girls, but are an avid follower of the Batman animated shows, you'll immediately recognize some familiar voices. Reprising their roles are Tara Strong (Batgirl), Arleen Sorkin (Harley Quinn), Diane Pershing (Poison Ivy), and Adrienne Barbeau (Catwoman).</p>\",\"updated\":1477705751,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/7349\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/417516\"}}}},{\"score\":8.792551,\"show\":{\"id\":8198,\"url\":\"http://www.tvmaze.com/shows/8198/transit-girls\",\"name\":\"Transit Girls\",\"type\":\"Scripted\",\"language\":\"Japanese\",\"genres\":[],\"status\":\"Ended\",\"runtime\":25,\"premiered\":\"2015-11-07\",\"schedule\":{\"time\":\"23:40\",\"days\":[\"Saturday\"]},\"rating\":{\"average\":null},\"weight\":0,\"network\":{\"id\":131,\"name\":\"Fuji TV\",\"country\":{\"name\":\"Japan\",\"code\":\"JP\",\"timezone\":\"Asia/Tokyo\"}},\"webChannel\":null,\"externals\":{\"tvrage\":null,\"thetvdb\":303061,\"imdb\":\"tt5138044\"},\"image\":{\"medium\":\"http://tvmazecdn.com/uploads/images/medium_portrait/29/74245.jpg\",\"original\":\"http://tvmazecdn.com/uploads/images/original_untouched/29/74245.jpg\"},\"summary\":\"<p>The story follows the relationship between the two girls, Sayuri and\\n Yui, as they start to live together under one roof as step-sisters. \\nDespite their initial distaste for each other and the fact that they \\ncouldn't be more opposite in looks and personality, they eventually \\nstart to develop feelings for each other... How will their romance take \\nshape?</p>\",\"updated\":1457971816,\"_links\":{\"self\":{\"href\":\"http://api.tvmaze.com/shows/8198\"},\"previousepisode\":{\"href\":\"http://api.tvmaze.com/episodes/453835\"}}}}]"

    public class JSONResponse
    {
        [JsonProperty(PropertyName = "score")]
        public string score { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string url { get; set; }
    }
    public class Schedule
    {
        public string time { get; set; }
        public List<object> days { get; set; }
    }

    public class Rating
    {
        public double? average { get; set; }
    }

    public class Country
    {
        public string name { get; set; }
        public string code { get; set; }
        public string timezone { get; set; }
    }

    public class Network
    {
        public int id { get; set; }
        public string name { get; set; }
        public Country country { get; set; }
    }

    public class Externals
    {
        public int? tvrage { get; set; }
        public int? thetvdb { get; set; }
        public string imdb { get; set; }
    }

    public class Image
    {
        public string medium { get; set; }
        public string original { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }

    public class Previousepisode
    {
        public string href { get; set; }
    }

    public class Nextepisode
    {
        public string href { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Previousepisode previousepisode { get; set; }
        public Nextepisode nextepisode { get; set; }
    }

    public class Show
    {
        public int id { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string language { get; set; }
        public List<object> genres { get; set; }
        public string status { get; set; }
        public int? runtime { get; set; }
        public string premiered { get; set; }
        public Schedule schedule { get; set; }
        public Rating rating { get; set; }
        public int weight { get; set; }
        public Network network { get; set; }
        public object webChannel { get; set; }
        public Externals externals { get; set; }
        public Image image { get; set; }
        public string summary { get; set; }
        public int updated { get; set; }
        public Links _links { get; set; }
    }

    public class RootObject
    {
        public double score { get; set; }
        public Show show { get; set; }
    }
}
   