using System;
using Notebook;
using Random = UnityEngine.Random;

namespace Notebook
{
    public static class LoremIpsumLibrary
    {
        public static string[] Paragraphs = new string[]
        {
            "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam nec pulvinar ligula. Duis convallis lorem et massa convallis vulputate. Sed lacinia non nunc sit amet auctor. Suspendisse ex lectus, venenatis a vehicula ac, dapibus vitae risus. Cras malesuada dolor eget erat egestas, vel mattis ipsum auctor. Donec condimentum et dolor nec condimentum. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Aenean rutrum lacus urna, a semper augue egestas vel. Vestibulum sit amet urna eu metus lacinia sodales. Ut in metus quis tellus molestie porttitor vel tempor velit. Praesent consequat aliquet finibus. Maecenas iaculis ac elit eu vestibulum.",
            "Donec at risus tempus, venenatis quam non, hendrerit quam. Proin sollicitudin nunc hendrerit, mattis erat eget, molestie mi. Vestibulum pulvinar tincidunt mi non tincidunt. Praesent cursus sodales libero quis placerat. Curabitur turpis arcu, luctus nec scelerisque feugiat, iaculis a nibh. Nulla mollis interdum felis, a hendrerit tortor pulvinar non. Mauris quis vulputate augue, sed malesuada quam. Praesent in fermentum nisi. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.",
            "Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Curabitur ut nibh molestie, lobortis odio eu, iaculis urna. Ut eget egestas lectus. In hac habitasse platea dictumst. Integer quam mauris, placerat in efficitur sed, placerat in risus. Sed tincidunt placerat lacus, eu euismod est aliquam a. Donec facilisis varius erat, et cursus metus auctor ac. Maecenas commodo nisl in turpis scelerisque, condimentum tincidunt nisl tempor. Pellentesque ac mauris tempus velit semper semper at eu mauris. Mauris pellentesque nibh pellentesque lacus molestie pellentesque.",
            "Donec dictum turpis est, sed finibus arcu accumsan ullamcorper. Phasellus nec orci risus. Morbi maximus leo nec enim euismod lacinia. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Praesent ut sodales lacus. Aliquam erat volutpat. Vestibulum viverra eget nisl eget tristique. Suspendisse pellentesque elementum leo ut tempus. Proin condimentum quis lorem ut consectetur. Etiam id laoreet urna.",
            "Quisque vel nisi et libero iaculis dapibus vitae sed est. In fermentum nisi velit, at rhoncus leo elementum aliquet. Quisque auctor lectus quis porta sodales. Phasellus mattis interdum tincidunt. Mauris ornare convallis felis, id molestie tellus accumsan sit amet. Cras non tempor orci, vel volutpat justo. Maecenas vitae rhoncus neque. Duis molestie posuere dui eget aliquet. Phasellus neque nisi, volutpat non consequat ut, fermentum a magna. Nulla eu velit ut justo sodales porttitor non quis lorem. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Etiam in ex id est eleifend volutpat. Nulla varius, augue id tincidunt ultricies, ante orci faucibus purus, sit amet malesuada purus tellus sit amet leo. Curabitur varius iaculis nibh, ut consectetur urna auctor porttitor. Duis est nibh, dapibus ut hendrerit id, facilisis sed arcu."
        };

        public static string[] ListPoints = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.\nCurabitur viverra augue quis est faucibus hendrerit.\n\nAenean ut felis auctor, placerat dolor pulvinar, maximus eros.\nAliquam eget leo ultrices, rutrum sapien vitae, sodales augue.\nUt quis justo eget felis accumsan consectetur ac id odio.\n\nPraesent aliquet nisl in lacus rhoncus lacinia.\nPhasellus at enim ac nunc eleifend bibendum eu vitae enim.\nNunc posuere augue eget justo pretium malesuada.\nDonec non felis ac ipsum gravida sagittis sit amet sed massa.\n\nUt sit amet ante eget ex lobortis pellentesque sed sit amet dui.\nCras non elit in ligula tincidunt vestibulum nec sit amet lacus.\nCras euismod risus ac ipsum ornare, vel vehicula lacus convallis.\n\nPhasellus malesuada tellus vitae nisl ultricies, at hendrerit eros tempor.\nProin aliquet elit at dui porttitor condimentum.\nUt et eros eleifend, euismod ex sed, dictum libero.\nPraesent non magna aliquet, blandit elit sed, dapibus dui.\n\nEtiam tempor sapien sed tortor efficitur, ut tempor elit hendrerit.\nMaecenas vehicula nulla sit amet lacus maximus lacinia.\nFusce sed mi eu elit pulvinar fringilla sit amet vel leo.\nPraesent maximus risus sit amet ipsum facilisis, et lacinia ipsum volutpat.\n\n"
                .Split(@"\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        public static string GetRandomParagraph()
        {
            return Paragraphs[Random.Range(0, Paragraphs.Length - 1)];
        }
        public static string GetRandomListPoint()
        {
            return ListPoints[Random.Range(0, ListPoints.Length - 1)];
        }
    }
}