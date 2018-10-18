﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using UnityEngine;
using System.Xml;
using System.Collections.Generic;
using Thanos.Resource;

namespace AssemblyCSharp
{
}

//namespace AssemblyCSharp
//{
public class ReadSkillConfig
{
    XmlDocument xmlDoc = null;

    public ReadSkillConfig()
    {
    }
    //public static ReadSkillConfig inst = new ReadSkillConfig("Config/SkillCfg");
    public ReadSkillConfig(string xmlFilePath)
    {
        //TextAsset xmlfile = Resources.Load(xmlFilePath) as TextAsset;
        ResourceItem xmlfileUnit = ResourcesManager.Instance.loadImmediate(xmlFilePath, ResourceType.ASSET);
        TextAsset xmlfile = xmlfileUnit.Asset as TextAsset;

        if (!xmlfile)
        {
            //Debug.LogError(" error infos: 没有找到指定的xml文件：" + xmlFilePath);
        }

        xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlfile.text);

        XmlNodeList infoNodeList = xmlDoc.SelectSingleNode("SkillCfg ").ChildNodes;

        for (int i = 0; i < infoNodeList.Count; i++)
        {//(XmlNode xNode in infoNodeList)
            if ((infoNodeList[i] as XmlElement).GetAttributeNode("un32ID") == null)
                continue;

            string typeName = (infoNodeList[i] as XmlElement).GetAttributeNode("un32ID").InnerText;
            //Debug.LogError(typeName);
            SkillConfigInfo skillinfo = new SkillConfigInfo();
            skillinfo.SkillID = Convert.ToUInt32(typeName);

            //SkillConfigInfo.NpcId = Convert.ToInt32(typeName);
            foreach (XmlElement xEle in infoNodeList[i].ChildNodes)
            {
                #region 搜索
                switch (xEle.Name)
                {
                    case "szName":
                        {
                            skillinfo.SkillName = Convert.ToString(xEle.InnerText);
                        }
                        break;
                    case "n32PrepareTime":
                        {
                            skillinfo.PrepareTime = Convert.ToInt32(xEle.InnerText);
                        }
                        break;
                    case "n32ReleaseDistance":
                        {
                            skillinfo.Range = Convert.ToSingle(xEle.InnerText) / 100.0f;
                        }
                        break;
                    case "attackEffect":
                        {
                            skillinfo.AttackEffect = Convert.ToString(xEle.InnerText);
                        }
                        break;
                    case "woundEffect":
                        {
                            skillinfo.WoundEffect = Convert.ToString(xEle.InnerText);
                        }
                        break;
                    case "bIfNormal":
                        {
                            skillinfo.IsNormalSkill = Convert.ToInt32(xEle.InnerText);
                        }
                        break;
                    case "SkillType":
                        skillinfo.SkillType = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "FlySpeed":
                        skillinfo.FlySpeed = Convert.ToInt32(xEle.InnerText) / 100.0f;
                        ;
                        break;
                    case "AEffectTime":
                        skillinfo.AEffectTime = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "WEffectTime":
                        skillinfo.WEffectTime = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "n32ProjectileNum":
                        skillinfo.ProjectNum = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "n32RangePar1":
                        skillinfo.RangeParam1 = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "NreRangePar2":
                        skillinfo.RangeParam2 = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "n32CoolDown":
                        skillinfo.CdTime = Convert.ToSingle(xEle.InnerText);
                        break;
                    case "eLifeTime":
                        skillinfo.LifeTime = Convert.ToInt32(xEle.InnerText) / 1000.0f;
                        break;
                    case "eReleaseWay":
                        skillinfo.SkillLockTarget = Convert.ToInt32(xEle.InnerText);
                        break;
                    case "buffIcon":
                        skillinfo.iconName = Convert.ToString(xEle.InnerText);
                        break;
                    case "FlySound":
                        {
                            skillinfo.flySound = Convert.ToString(xEle.InnerText);
                        }
                        break;
                    case "HitSound":
                        {
                            skillinfo.hitSound = Convert.ToString(xEle.InnerText);
                        }
                        break;
                    case "n32UseMP":
                        {
                            skillinfo.MpCost = Convert.ToInt32(xEle.InnerText);
                        }
                        break;
                    case "bIsConsumeSkill":
                        {
                            skillinfo.IsAbsorbSkill = Convert.ToInt32(xEle.InnerText);
                        }
                        break;
                    case "eSummonEffect":
                        {
                            skillinfo.absorbRes = Convert.ToString(xEle.InnerText);
                        }
                        break;

                }
                #endregion
            }
            //Debug.LogError("add skill" + skillinfo.SkillID);
            ConfigReader.skillXmlInfoDict.Add(skillinfo.SkillID, skillinfo);
        }

    }
}

public class SkillConfigInfo : System.Object
{
    #region 技能信息
    public uint SkillID;
    public string absorbRes;
    public int IsAbsorbSkill;
    public int IsNormalSkill;
    public String SkillName;
    public int PrepareTime;
    public float CdTime;
    public float Range;				//判断攻击距离
    public String AttackEffect;
    public String WoundEffect;
    public int SkillType;			//1,普通近战攻击2,普通远程3不锁定目标不穿透 4不锁定目标穿透
    public float FlySpeed;			//飞行速度
    public int AEffectTime;					//攻击特效消失时间
    public int WEffectTime;					//受击特效消失时间
    public int ProjectNum;									//发射数量
    public int RangeParam1;						//范围参数1 	比如半径 长度
    public int RangeParam2;						//范围参数2	比如角度 宽度
    public float LifeTime;                            //生存时间
    public int SkillLockTarget;                        //0,不需要锁定目标，1，锁定目标不需要转向，2，锁定目标需要转向,3,锁定目标的时候需要转向，不锁定目标的时候不需要转向
    public string iconName;                             //图标名字
    public string hitSound;
    public string flySound;
    public int MpCost;
    #endregion
}
//}




























