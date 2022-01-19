using CompositionEx2.Entities;

Comment c1 = new("Have a nice trip");
Comment c2 = new("Wow that's awesome!");

Post post1 = new Post(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
    );

post1.AddComment(c1);
post1.AddComment(c2);

Comment c3 = new("Good night");
Comment c4 = new("May the Force be with you");

Post post2 = new Post(
    DateTime.Parse("28/07/2018 23:14:19"),
    "Good night guys",
    "See you tomorrow",
    5
    );

post2.AddComment(c3);
post2.AddComment(c4);
