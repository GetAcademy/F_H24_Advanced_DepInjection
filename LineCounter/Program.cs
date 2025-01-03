
using LineCounter;
using LineCounter.LineSources;


//var lineSource = new FileLineSource("vgsak.txt");
//var lineSource = new KeyboardLineSource();
var lineSource = new WebLineSource("https://www.vg.no/nyheter/i/nybAQd/lo-ber-om-at-nho-blir-med-paa-erna-solbergs-fredning-av-sykeloennsordningen");
var service = new LineCountService(lineSource);
var stats = service.GetStats("er");
stats.Show();
