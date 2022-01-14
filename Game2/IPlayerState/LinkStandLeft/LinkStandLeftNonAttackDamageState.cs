﻿using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace Sprint2 
{
    public class LinkStandLeftNonAttackDamageState:IPlayerstate
    {
        private Link link;
        public LinkStandLeftNonAttackDamageState(Link link)
        {
            if (link == null)
            {
                throw new ArgumentNullException(nameof(link));
            }
            link.linkSprite = LinkSpriteFactory.Instance.CreateLinkStandSprite("Left", true);
            this.link = link;
            this.link.ChangeDirection(2);
            Link.ifDamage = true;
            

        }
        public void Win()
        {
            link.state = new LinkWinningState(link);

        }
        public void ChangeToRight()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandRightNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandRightNonAttackNonDamageState(link);
            }
        }
        public void ChangeToLeft()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToUp()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandUpNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandUpNonAttackNonDamageState(link);
            }
        }
        public void ChangeToDown()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandDownNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkStandDownNonAttackNonDamageState(link);
            }
        }
        public void GetDamaged()
        {
            link.state = new LinkStandLeftNonAttackDamageState(link);

        }
        public void Attack()
        {
            if (Link.ifDamage)
            {
                link.state = new LinkStandLeftAttackDamageState(link);
            }
        }
        public void ChangeToWalk()
        {

            if (Link.ifDamage)
            {
                link.state = new LinkWalkLeftNonAttackDamageState(link);
            }
            else
            {
                link.state = new LinkWalkLeftNonAttackNonDamageState(link);
            }
        }
        public void ChangeToStand()
        {
            if (!Link.ifDamage)
            {
                link.state = new LinkStandLeftNonAttackNonDamageState(link);
            }
        }
        public void LinkWithItemUp(int item)
        {
            link.state = new LinkWithItemUpState(link, item);
        }

        public void LinkWithItemDown(int item)
        {
            link.state = new LinkWithItemDownState(link, item);
        }

        public void LinkWithItemLeft(int item)
        {
            link.state = new LinkWithItemLeftState(link, item);
        }

        public void LinkWithItemRight(int item)
        {
            link.state = new LinkWithItemRightState(link, item);
        }
    }
}