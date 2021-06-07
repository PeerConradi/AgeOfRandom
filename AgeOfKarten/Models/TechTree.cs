using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgeOfKarten.Models
{
    // HINWEIS: Für den generierten Code ist möglicherweise mindestens .NET Framework 4.5 oder .NET Core/Standard 2.0 erforderlich.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class techtree
    {

        private techtreeTech[] techField;

        private byte versionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tech")]
        public techtreeTech[] tech
        {
            get
            {
                return this.techField;
            }
            set
            {
                this.techField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTech
    {

        public string rollovertextid { get; set; }

        public uint displaynameid { get; set; }


        public string icon { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechCost
    {

        private string resourcetypeField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resourcetype
        {
            get
            {
                return this.resourcetypeField;
            }
            set
            {
                this.resourcetypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechEffect
    {

        private techtreeTechEffectTarget targetField;

        private string typeField;

        private string actionField;

        private decimal amountField;

        private string subtypeField;

        private string unittypeField;

        private string relativityField;

        /// <remarks/>
        public techtreeTechEffectTarget target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subtype
        {
            get
            {
                return this.subtypeField;
            }
            set
            {
                this.subtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unittype
        {
            get
            {
                return this.unittypeField;
            }
            set
            {
                this.unittypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relativity
        {
            get
            {
                return this.relativityField;
            }
            set
            {
                this.relativityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechEffectTarget
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechEffects
    {

        private techtreeTechEffectsEffect[] effectField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("effect")]
        public techtreeTechEffectsEffect[] effect
        {
            get
            {
                return this.effectField;
            }
            set
            {
                this.effectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechEffectsEffect
    {

        private string[] techField;

        private techtreeTechEffectsEffectTarget targetField;

        private string[] unitsField;

        private string[] textField;

        private string typeField;

        private decimal amountField;

        private bool amountFieldSpecified;

        private string subtypeField;

        private string relativityField;

        private string statusField;

        private string actionField;

        private string tech1Field;

        private uint newnameField;

        private bool newnameFieldSpecified;

        private int newrolloverField;

        private bool newrolloverFieldSpecified;

        private string resourceField;

        private byte allactionsField;

        private bool allactionsFieldSpecified;

        private string unittypeField;

        private string protoField;

        private string cultureField;

        private uint newshortrolloverField;

        private bool newshortrolloverFieldSpecified;

        private string tacticField;

        private byte pageField;

        private bool pageFieldSpecified;

        private byte columnField;

        private bool columnFieldSpecified;

        private bool deactivateField;

        private bool deactivateFieldSpecified;

        private string reqtechField;

        private bool allField;

        private bool allFieldSpecified;

        private decimal delayField;

        private bool delayFieldSpecified;

        private decimal resvalueField;

        private bool resvalueFieldSpecified;

        private string componentField;

        private string convertsettlersField;

        private string protopowerField;

        private string toprotoidField;

        private string fromprotoidField;

        private decimal multiplierField;

        private bool multiplierFieldSpecified;

        private string toresourceField;

        private string fromresourceField;

        private string hitpercenttypeField;

        private decimal amount2Field;

        private bool amount2FieldSpecified;

        private string unittype2Field;

        private string civField;

        private string pathField;

        private uint selfmsgField;

        private bool selfmsgFieldSpecified;

        private uint playermsgField;

        private bool playermsgFieldSpecified;

        private uint neweditornameField;

        private bool neweditornameFieldSpecified;

        private string commandField;

        private uint stringidField;

        private bool stringidFieldSpecified;

        private string newtypeField;

        private string counttypeField;

        private string fromtacticField;

        private string totacticField;

        private string copyField;

        private sbyte maxcountField;

        private bool maxcountFieldSpecified;

        private byte ageprereqField;

        private bool ageprereqFieldSpecified;

        private byte unitcountField;

        private bool unitcountFieldSpecified;

        private byte infiniteinlastageField;

        private bool infiniteinlastageFieldSpecified;

        private bool includeselfField;

        private bool includeselfFieldSpecified;

        private byte selectField;

        private bool selectFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tech")]
        public string[] tech
        {
            get
            {
                return this.techField;
            }
            set
            {
                this.techField = value;
            }
        }

        /// <remarks/>
        public techtreeTechEffectsEffectTarget target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("unit", IsNullable = false)]
        public string[] units
        {
            get
            {
                return this.unitsField;
            }
            set
            {
                this.unitsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified
        {
            get
            {
                return this.amountFieldSpecified;
            }
            set
            {
                this.amountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string subtype
        {
            get
            {
                return this.subtypeField;
            }
            set
            {
                this.subtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relativity
        {
            get
            {
                return this.relativityField;
            }
            set
            {
                this.relativityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("tech")]
        public string tech1
        {
            get
            {
                return this.tech1Field;
            }
            set
            {
                this.tech1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint newname
        {
            get
            {
                return this.newnameField;
            }
            set
            {
                this.newnameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newnameSpecified
        {
            get
            {
                return this.newnameFieldSpecified;
            }
            set
            {
                this.newnameFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public int newrollover
        {
            get
            {
                return this.newrolloverField;
            }
            set
            {
                this.newrolloverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newrolloverSpecified
        {
            get
            {
                return this.newrolloverFieldSpecified;
            }
            set
            {
                this.newrolloverFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string resource
        {
            get
            {
                return this.resourceField;
            }
            set
            {
                this.resourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte allactions
        {
            get
            {
                return this.allactionsField;
            }
            set
            {
                this.allactionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allactionsSpecified
        {
            get
            {
                return this.allactionsFieldSpecified;
            }
            set
            {
                this.allactionsFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unittype
        {
            get
            {
                return this.unittypeField;
            }
            set
            {
                this.unittypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string proto
        {
            get
            {
                return this.protoField;
            }
            set
            {
                this.protoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string culture
        {
            get
            {
                return this.cultureField;
            }
            set
            {
                this.cultureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint newshortrollover
        {
            get
            {
                return this.newshortrolloverField;
            }
            set
            {
                this.newshortrolloverField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool newshortrolloverSpecified
        {
            get
            {
                return this.newshortrolloverFieldSpecified;
            }
            set
            {
                this.newshortrolloverFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tactic
        {
            get
            {
                return this.tacticField;
            }
            set
            {
                this.tacticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte page
        {
            get
            {
                return this.pageField;
            }
            set
            {
                this.pageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pageSpecified
        {
            get
            {
                return this.pageFieldSpecified;
            }
            set
            {
                this.pageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte column
        {
            get
            {
                return this.columnField;
            }
            set
            {
                this.columnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool columnSpecified
        {
            get
            {
                return this.columnFieldSpecified;
            }
            set
            {
                this.columnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deactivate
        {
            get
            {
                return this.deactivateField;
            }
            set
            {
                this.deactivateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool deactivateSpecified
        {
            get
            {
                return this.deactivateFieldSpecified;
            }
            set
            {
                this.deactivateFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string reqtech
        {
            get
            {
                return this.reqtechField;
            }
            set
            {
                this.reqtechField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool all
        {
            get
            {
                return this.allField;
            }
            set
            {
                this.allField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool allSpecified
        {
            get
            {
                return this.allFieldSpecified;
            }
            set
            {
                this.allFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal delay
        {
            get
            {
                return this.delayField;
            }
            set
            {
                this.delayField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool delaySpecified
        {
            get
            {
                return this.delayFieldSpecified;
            }
            set
            {
                this.delayFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal resvalue
        {
            get
            {
                return this.resvalueField;
            }
            set
            {
                this.resvalueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resvalueSpecified
        {
            get
            {
                return this.resvalueFieldSpecified;
            }
            set
            {
                this.resvalueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string component
        {
            get
            {
                return this.componentField;
            }
            set
            {
                this.componentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string convertsettlers
        {
            get
            {
                return this.convertsettlersField;
            }
            set
            {
                this.convertsettlersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string protopower
        {
            get
            {
                return this.protopowerField;
            }
            set
            {
                this.protopowerField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toprotoid
        {
            get
            {
                return this.toprotoidField;
            }
            set
            {
                this.toprotoidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromprotoid
        {
            get
            {
                return this.fromprotoidField;
            }
            set
            {
                this.fromprotoidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal multiplier
        {
            get
            {
                return this.multiplierField;
            }
            set
            {
                this.multiplierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool multiplierSpecified
        {
            get
            {
                return this.multiplierFieldSpecified;
            }
            set
            {
                this.multiplierFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string toresource
        {
            get
            {
                return this.toresourceField;
            }
            set
            {
                this.toresourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromresource
        {
            get
            {
                return this.fromresourceField;
            }
            set
            {
                this.fromresourceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hitpercenttype
        {
            get
            {
                return this.hitpercenttypeField;
            }
            set
            {
                this.hitpercenttypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal amount2
        {
            get
            {
                return this.amount2Field;
            }
            set
            {
                this.amount2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amount2Specified
        {
            get
            {
                return this.amount2FieldSpecified;
            }
            set
            {
                this.amount2FieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string unittype2
        {
            get
            {
                return this.unittype2Field;
            }
            set
            {
                this.unittype2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string civ
        {
            get
            {
                return this.civField;
            }
            set
            {
                this.civField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint selfmsg
        {
            get
            {
                return this.selfmsgField;
            }
            set
            {
                this.selfmsgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool selfmsgSpecified
        {
            get
            {
                return this.selfmsgFieldSpecified;
            }
            set
            {
                this.selfmsgFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint playermsg
        {
            get
            {
                return this.playermsgField;
            }
            set
            {
                this.playermsgField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool playermsgSpecified
        {
            get
            {
                return this.playermsgFieldSpecified;
            }
            set
            {
                this.playermsgFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint neweditorname
        {
            get
            {
                return this.neweditornameField;
            }
            set
            {
                this.neweditornameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool neweditornameSpecified
        {
            get
            {
                return this.neweditornameFieldSpecified;
            }
            set
            {
                this.neweditornameFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string command
        {
            get
            {
                return this.commandField;
            }
            set
            {
                this.commandField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint stringid
        {
            get
            {
                return this.stringidField;
            }
            set
            {
                this.stringidField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stringidSpecified
        {
            get
            {
                return this.stringidFieldSpecified;
            }
            set
            {
                this.stringidFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string newtype
        {
            get
            {
                return this.newtypeField;
            }
            set
            {
                this.newtypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string counttype
        {
            get
            {
                return this.counttypeField;
            }
            set
            {
                this.counttypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string fromtactic
        {
            get
            {
                return this.fromtacticField;
            }
            set
            {
                this.fromtacticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string totactic
        {
            get
            {
                return this.totacticField;
            }
            set
            {
                this.totacticField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string copy
        {
            get
            {
                return this.copyField;
            }
            set
            {
                this.copyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public sbyte maxcount
        {
            get
            {
                return this.maxcountField;
            }
            set
            {
                this.maxcountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxcountSpecified
        {
            get
            {
                return this.maxcountFieldSpecified;
            }
            set
            {
                this.maxcountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ageprereq
        {
            get
            {
                return this.ageprereqField;
            }
            set
            {
                this.ageprereqField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ageprereqSpecified
        {
            get
            {
                return this.ageprereqFieldSpecified;
            }
            set
            {
                this.ageprereqFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte unitcount
        {
            get
            {
                return this.unitcountField;
            }
            set
            {
                this.unitcountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool unitcountSpecified
        {
            get
            {
                return this.unitcountFieldSpecified;
            }
            set
            {
                this.unitcountFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte infiniteinlastage
        {
            get
            {
                return this.infiniteinlastageField;
            }
            set
            {
                this.infiniteinlastageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool infiniteinlastageSpecified
        {
            get
            {
                return this.infiniteinlastageFieldSpecified;
            }
            set
            {
                this.infiniteinlastageFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool includeself
        {
            get
            {
                return this.includeselfField;
            }
            set
            {
                this.includeselfField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool includeselfSpecified
        {
            get
            {
                return this.includeselfFieldSpecified;
            }
            set
            {
                this.includeselfFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte select
        {
            get
            {
                return this.selectField;
            }
            set
            {
                this.selectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool selectSpecified
        {
            get
            {
                return this.selectFieldSpecified;
            }
            set
            {
                this.selectFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechEffectsEffectTarget
    {

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechPrereqs
    {

        private techtreeTechPrereqsTechstatus[] techstatusField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("techstatus")]
        public techtreeTechPrereqsTechstatus[] techstatus
        {
            get
            {
                return this.techstatusField;
            }
            set
            {
                this.techstatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class techtreeTechPrereqsTechstatus
    {

        private string statusField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        cost,

        /// <remarks/>
        dbid,

        /// <remarks/>
        displaynameid,

        /// <remarks/>
        effect,

        /// <remarks/>
        effects,

        /// <remarks/>
        flag,

        /// <remarks/>
        icon,

        /// <remarks/>
        icontexturecoords,

        /// <remarks/>
        iconwpf,

        /// <remarks/>
        prereqs,

        /// <remarks/>
        prereqsnotmetrollovertextid,

        /// <remarks/>
        researchpoints,

        /// <remarks/>
        revolutionciv,

        /// <remarks/>
        rollovertextid,

        /// <remarks/>
        status,
    }
}
