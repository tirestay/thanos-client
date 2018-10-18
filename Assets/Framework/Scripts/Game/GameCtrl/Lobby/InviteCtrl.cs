﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Thanos.Ctrl
{
    public class InviteCtrl : Singleton<InviteCtrl>
    {
        public void Enter(UInt64 sGUID,string nickName)
        {
            EventCenter.Broadcast((Int32)GameEventEnum.GameEvent_InviteEnter,sGUID,nickName);
        }

        public void Exit()
        {
            EventCenter.Broadcast((Int32)GameEventEnum.GameEvent_InviteExit);
        }

        public void ChangeInvite(UInt64 sGUID, string nickName)
        {
            EventCenter.Broadcast((Int32)GameEventEnum.GameEvent_InviteChange,sGUID,nickName);
        }

        public void AcceptAddFriend(UInt64 sGUID)
        {
            HolyGameLogic.Instance.EmsgTocs__GCReplyAddFriendRequst(sGUID, true);
        }
        public void CanelAddFriend(UInt64 sGUID)
        {
            HolyGameLogic.Instance.EmsgTocs__GCReplyAddFriendRequst(sGUID, false);
        }

        public bool AddDic(UInt64 sGUID, string nickName)
        {
            if (!InvatiDic.ContainsKey(sGUID))
            {
                InvatiDic.Add(sGUID, nickName);
                return true;
            }
            return false;
        }
        public void RemoveDic(UInt64 sGUID)
        {
            if (InvatiDic.ContainsKey(sGUID))
            {
                InvatiDic[sGUID] = null;
                InvatiDic.Remove(sGUID);
            }
            if (InvatiDic.Count <= 0)
            {
                InviteCtrl.Instance.Exit();
            }
            else
            {
                sGUID = InvatiDic.ElementAt(InvatiDic.Count - 1).Key;
                string nickName = InvatiDic.ElementAt(InvatiDic.Count - 1).Value;
                ChangeInvite(sGUID, nickName);
            }
        }
        public Dictionary<UInt64, string> InvatiDic = new Dictionary<ulong, string>();
    }
}
