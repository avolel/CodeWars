
namespace CodeWarsStyle_RankingSystem
{
    public class User
    {
        public int rank { get; set; } = -8;
        public int progress { get; set; }
        public void incProgress(int r)
        {
            int diffRank = rank - r;
            int progression = ((10 * diffRank * diffRank) != 0);
        }

    }
}