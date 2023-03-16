namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            // deze opdracht was best moeilijk omdat de comments moeilijk waren te begrijpen
            // heb meerdere mensen die kunnen vouchen hiervoor
            if (enemy.flying || enemy.incoporial || enemy.subterranian)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool CanPassWater(Enemy enemy)
        {
            if (enemy.flying || enemy.incoporial || enemy.subterranian)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}