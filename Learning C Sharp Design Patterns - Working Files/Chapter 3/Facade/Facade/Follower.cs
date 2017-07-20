using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Follower
    {
        public bool Follow(User Follower, User Following)
        {
            bool result;

            // add user as follower
            result = Follower.Follow(Following);
            if (!result)
            {
                return false;
            }

            // notify user that they have an added follower
            result = Follower.FollowerAdded(Follower);
            if (!result)
            {
                return false;
            }

            // post that user is now following a new person
            result = Follower.FollowingTextPost(Following);
            if (!result)
            {
                return false;
            }

            // notify all of user's followers of new following activity
            result = Follower.NotifyFollowers(Following);
            if (!result)
            {
                return false;
            }

            return true;
        }
    }
}
