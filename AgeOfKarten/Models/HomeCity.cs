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
    public partial class homecity
    {

        private string visualField;

        private string watervisualField;

        private string backgroundvisualField;

        private string pathdataField;

        private string cameraField;

        private string widescreencameraField;

        private byte transportroundtriptimeField;

        private byte transportactivationtimeField;

        private byte levelField;

        private byte skillpointsField;

        private string lightsetField;

        private string watertypeField;

        private byte numpropunlocksearnedField;

        private string ambientsoundsField;

        private string xsaiField;

        private homecityCoffers coffersField;

        private homecityCard[] cardsField;

        private homecityDecks decksField;

        private homecityBuilding[] buildingField;


        private homecityProp[] obtainablepropsField;

        /// <remarks/>
        public string civ { get; set; }

        /// <remarks/>
        public string name { get; set; }

        /// <remarks/>
        public string heroname { get; set; }

        /// <remarks/>
        public string gatherpointunit { get; set; }

        /// <remarks/>
        public string visual
        {
            get
            {
                return this.visualField;
            }
            set
            {
                this.visualField = value;
            }
        }

        /// <remarks/>
        public string watervisual
        {
            get
            {
                return this.watervisualField;
            }
            set
            {
                this.watervisualField = value;
            }
        }

        /// <remarks/>
        public string backgroundvisual
        {
            get
            {
                return this.backgroundvisualField;
            }
            set
            {
                this.backgroundvisualField = value;
            }
        }

        /// <remarks/>
        public string pathdata
        {
            get
            {
                return this.pathdataField;
            }
            set
            {
                this.pathdataField = value;
            }
        }

        /// <remarks/>
        public string camera
        {
            get
            {
                return this.cameraField;
            }
            set
            {
                this.cameraField = value;
            }
        }

        /// <remarks/>
        public string widescreencamera
        {
            get
            {
                return this.widescreencameraField;
            }
            set
            {
                this.widescreencameraField = value;
            }
        }

        /// <remarks/>
        public byte transportroundtriptime
        {
            get
            {
                return this.transportroundtriptimeField;
            }
            set
            {
                this.transportroundtriptimeField = value;
            }
        }

        /// <remarks/>
        public byte transportactivationtime
        {
            get
            {
                return this.transportactivationtimeField;
            }
            set
            {
                this.transportactivationtimeField = value;
            }
        }

        /// <remarks/>
        public byte level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        public byte skillpoints
        {
            get
            {
                return this.skillpointsField;
            }
            set
            {
                this.skillpointsField = value;
            }
        }

        /// <remarks/>
        public string lightset
        {
            get
            {
                return this.lightsetField;
            }
            set
            {
                this.lightsetField = value;
            }
        }

        /// <remarks/>
        public string watertype
        {
            get
            {
                return this.watertypeField;
            }
            set
            {
                this.watertypeField = value;
            }
        }

        /// <remarks/>
        public byte numpropunlocksearned
        {
            get
            {
                return this.numpropunlocksearnedField;
            }
            set
            {
                this.numpropunlocksearnedField = value;
            }
        }

        /// <remarks/>
        public string ambientsounds
        {
            get
            {
                return this.ambientsoundsField;
            }
            set
            {
                this.ambientsoundsField = value;
            }
        }

        /// <remarks/>
        public string xsai
        {
            get
            {
                return this.xsaiField;
            }
            set
            {
                this.xsaiField = value;
            }
        }

        /// <remarks/>
        public homecityCoffers coffers
        {
            get
            {
                return this.coffersField;
            }
            set
            {
                this.coffersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("card", IsNullable = false)]
        public homecityCard[] cards
        {
            get
            {
                return this.cardsField;
            }
            set
            {
                this.cardsField = value;
            }
        }

        /// <remarks/>
        public homecityDecks decks
        {
            get
            {
                return this.decksField;
            }
            set
            {
                this.decksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("building")]
        public homecityBuilding[] building { get; set; }

        /// <remarks/>
        //[System.Xml.Serialization.XmlArrayItemAttribute("waypoint", IsNullable = false)]
        //public homecityWaypoint[] waypoints { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("prop", IsNullable = false)]
        public homecityProp[] obtainableprops { get; set; }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityCoffers
    {

        private homecityCoffersCurrent currentField;

        private homecityCoffersMaximum maximumField;

        /// <remarks/>
        public homecityCoffersCurrent current
        {
            get
            {
                return this.currentField;
            }
            set
            {
                this.currentField = value;
            }
        }

        /// <remarks/>
        public homecityCoffersMaximum maximum
        {
            get
            {
                return this.maximumField;
            }
            set
            {
                this.maximumField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityCoffersCurrent
    {

        private byte foodField;

        private byte woodField;

        private byte goldField;

        private byte fameField;

        private byte shipsField;

        private byte skillpointsField;

        private byte xpField;

        /// <remarks/>
        public byte food
        {
            get
            {
                return this.foodField;
            }
            set
            {
                this.foodField = value;
            }
        }

        /// <remarks/>
        public byte wood
        {
            get
            {
                return this.woodField;
            }
            set
            {
                this.woodField = value;
            }
        }

        /// <remarks/>
        public byte gold
        {
            get
            {
                return this.goldField;
            }
            set
            {
                this.goldField = value;
            }
        }

        /// <remarks/>
        public byte fame
        {
            get
            {
                return this.fameField;
            }
            set
            {
                this.fameField = value;
            }
        }

        /// <remarks/>
        public byte ships
        {
            get
            {
                return this.shipsField;
            }
            set
            {
                this.shipsField = value;
            }
        }

        /// <remarks/>
        public byte skillpoints
        {
            get
            {
                return this.skillpointsField;
            }
            set
            {
                this.skillpointsField = value;
            }
        }

        /// <remarks/>
        public byte xp
        {
            get
            {
                return this.xpField;
            }
            set
            {
                this.xpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityCoffersMaximum
    {

        private byte foodField;

        private byte woodField;

        private byte goldField;

        private byte fameField;

        private byte shipsField;

        private sbyte skillpointsField;

        private sbyte xpField;

        /// <remarks/>
        public byte food
        {
            get
            {
                return this.foodField;
            }
            set
            {
                this.foodField = value;
            }
        }

        /// <remarks/>
        public byte wood
        {
            get
            {
                return this.woodField;
            }
            set
            {
                this.woodField = value;
            }
        }

        /// <remarks/>
        public byte gold
        {
            get
            {
                return this.goldField;
            }
            set
            {
                this.goldField = value;
            }
        }

        /// <remarks/>
        public byte fame
        {
            get
            {
                return this.fameField;
            }
            set
            {
                this.fameField = value;
            }
        }

        /// <remarks/>
        public byte ships
        {
            get
            {
                return this.shipsField;
            }
            set
            {
                this.shipsField = value;
            }
        }

        /// <remarks/>
        public sbyte skillpoints
        {
            get
            {
                return this.skillpointsField;
            }
            set
            {
                this.skillpointsField = value;
            }
        }

        /// <remarks/>
        public sbyte xp
        {
            get
            {
                return this.xpField;
            }
            set
            {
                this.xpField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityCard
    {

        private string nameField;

        private sbyte maxcountField;

        private byte levelField;

        private string prereqtechField;

        private byte ageField;

        private bool displayunitcountFieldSpecified;

        private object revoltcardField;

        private byte infiniteinlastageField;

        private bool infiniteinlastageFieldSpecified;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
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
        public byte level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        public string prereqtech
        {
            get
            {
                return this.prereqtechField;
            }
            set
            {
                this.prereqtechField = value;
            }
        }

        /// <remarks/>
        public byte age
        {
            get
            {
                return this.ageField;
            }
            set
            {
                this.ageField = value;
            }
        }

        /// <remarks/>
        public short displayunitcount { get; set; }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool displayunitcountSpecified
        {
            get
            {
                return this.displayunitcountFieldSpecified;
            }
            set
            {
                this.displayunitcountFieldSpecified = value;
            }
        }

        /// <remarks/>
        public object revoltcard
        {
            get
            {
                return this.revoltcardField;
            }
            set
            {
                this.revoltcardField = value;
            }
        }

        /// <remarks/>
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityDecks
    {

        private homecityDecksDeck[] deckField;

        private homecityDecksRevoltdeck revoltdeckField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("deck")]
        public homecityDecksDeck[] deck
        {
            get
            {
                return this.deckField;
            }
            set
            {
                this.deckField = value;
            }
        }

        /// <remarks/>
        public homecityDecksRevoltdeck revoltdeck
        {
            get
            {
                return this.revoltdeckField;
            }
            set
            {
                this.revoltdeckField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityDecksDeck
    {

        private string nameField;

        private object defaultField;

        private string[] cardsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public object @default
        {
            get
            {
                return this.defaultField;
            }
            set
            {
                this.defaultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("card", IsNullable = false)]
        public string[] cards
        {
            get
            {
                return this.cardsField;
            }
            set
            {
                this.cardsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityDecksRevoltdeck
    {

        private string nameField;

        private string[] cardsField;

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("card", IsNullable = false)]
        public string[] cards
        {
            get
            {
                return this.cardsField;
            }
            set
            {
                this.cardsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityBuilding
    {

        private object[] itemsField;

        private ItemsChoiceTypeHC[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("activetechs", typeof(homecityBuildingActivetechs))]
        [System.Xml.Serialization.XmlElementAttribute("camera", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("customizationbuilding", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("displaynamestringid", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("mercbuilding", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("name", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("obtainabletechs", typeof(homecityBuildingObtainabletechs))]
        [System.Xml.Serialization.XmlElementAttribute("portrait", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("rolloverstringid", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("trainbuilding", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("uix", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("uiy", typeof(ushort))]
        [System.Xml.Serialization.XmlElementAttribute("units", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("unlocklevel", typeof(byte))]
        [System.Xml.Serialization.XmlElementAttribute("validunits", typeof(object))]
        [System.Xml.Serialization.XmlElementAttribute("visual", typeof(homecityBuildingVisual))]
        [System.Xml.Serialization.XmlElementAttribute("widescreencamera", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceTypeHC[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityBuildingActivetechs
    {

        private homecityBuildingActivetechsTech[] techField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tech")]
        public homecityBuildingActivetechsTech[] tech
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityBuildingActivetechsTech
    {

        private decimal xField;

        private decimal yField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
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
    public partial class homecityBuildingObtainabletechs
    {

        private homecityBuildingObtainabletechsTech[] techField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tech")]
        public homecityBuildingObtainabletechsTech[] tech
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityBuildingObtainabletechsTech
    {

        private decimal xField;

        private decimal yField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
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
    public partial class homecityBuildingVisual
    {

        private string fileField;

        private string boneField;

        /// <remarks/>
        public string file
        {
            get
            {
                return this.fileField;
            }
            set
            {
                this.fileField = value;
            }
        }

        /// <remarks/>
        public string bone
        {
            get
            {
                return this.boneField;
            }
            set
            {
                this.boneField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema = false)]
    public enum ItemsChoiceTypeHC
    {

        /// <remarks/>
        activetechs,

        /// <remarks/>
        camera,

        /// <remarks/>
        customizationbuilding,

        /// <remarks/>
        displaynamestringid,

        /// <remarks/>
        mercbuilding,

        /// <remarks/>
        name,

        /// <remarks/>
        obtainabletechs,

        /// <remarks/>
        portrait,

        /// <remarks/>
        rolloverstringid,

        /// <remarks/>
        trainbuilding,

        /// <remarks/>
        uix,

        /// <remarks/>
        uiy,

        /// <remarks/>
        units,

        /// <remarks/>
        unlocklevel,

        /// <remarks/>
        validunits,

        /// <remarks/>
        visual,

        /// <remarks/>
        widescreencamera,
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityWaypoint
    {

        private string boneField;

        private byte fireworksField;

        private bool fireworksFieldSpecified;

        private byte vendorareaField;

        private bool vendorareaFieldSpecified;

        private byte shipmentendField;

        private bool shipmentendFieldSpecified;

        private byte shipmentstartField;

        private bool shipmentstartFieldSpecified;

        private byte fishingareaField;

        private bool fishingareaFieldSpecified;

        private byte dockField;

        private bool dockFieldSpecified;

        private byte illreputeareaField;

        private bool illreputeareaFieldSpecified;

        private byte performanceareaField;

        private bool performanceareaFieldSpecified;

        private byte exitField;

        private bool exitFieldSpecified;

        private byte vendorentryField;

        private bool vendorentryFieldSpecified;

        /// <remarks/>
        public string bone
        {
            get
            {
                return this.boneField;
            }
            set
            {
                this.boneField = value;
            }
        }

        /// <remarks/>
        public byte fireworks
        {
            get
            {
                return this.fireworksField;
            }
            set
            {
                this.fireworksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fireworksSpecified
        {
            get
            {
                return this.fireworksFieldSpecified;
            }
            set
            {
                this.fireworksFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte vendorarea
        {
            get
            {
                return this.vendorareaField;
            }
            set
            {
                this.vendorareaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vendorareaSpecified
        {
            get
            {
                return this.vendorareaFieldSpecified;
            }
            set
            {
                this.vendorareaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte shipmentend
        {
            get
            {
                return this.shipmentendField;
            }
            set
            {
                this.shipmentendField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentendSpecified
        {
            get
            {
                return this.shipmentendFieldSpecified;
            }
            set
            {
                this.shipmentendFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte shipmentstart
        {
            get
            {
                return this.shipmentstartField;
            }
            set
            {
                this.shipmentstartField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipmentstartSpecified
        {
            get
            {
                return this.shipmentstartFieldSpecified;
            }
            set
            {
                this.shipmentstartFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte fishingarea
        {
            get
            {
                return this.fishingareaField;
            }
            set
            {
                this.fishingareaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fishingareaSpecified
        {
            get
            {
                return this.fishingareaFieldSpecified;
            }
            set
            {
                this.fishingareaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte dock
        {
            get
            {
                return this.dockField;
            }
            set
            {
                this.dockField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool dockSpecified
        {
            get
            {
                return this.dockFieldSpecified;
            }
            set
            {
                this.dockFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte illreputearea
        {
            get
            {
                return this.illreputeareaField;
            }
            set
            {
                this.illreputeareaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool illreputeareaSpecified
        {
            get
            {
                return this.illreputeareaFieldSpecified;
            }
            set
            {
                this.illreputeareaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte performancearea
        {
            get
            {
                return this.performanceareaField;
            }
            set
            {
                this.performanceareaField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool performanceareaSpecified
        {
            get
            {
                return this.performanceareaFieldSpecified;
            }
            set
            {
                this.performanceareaFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte exit
        {
            get
            {
                return this.exitField;
            }
            set
            {
                this.exitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exitSpecified
        {
            get
            {
                return this.exitFieldSpecified;
            }
            set
            {
                this.exitFieldSpecified = value;
            }
        }

        /// <remarks/>
        public byte vendorentry
        {
            get
            {
                return this.vendorentryField;
            }
            set
            {
                this.vendorentryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool vendorentrySpecified
        {
            get
            {
                return this.vendorentryFieldSpecified;
            }
            set
            {
                this.vendorentryFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class homecityProp
    {

        private byte activeField;

        private bool activeFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte active
        {
            get
            {
                return this.activeField;
            }
            set
            {
                this.activeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified
        {
            get
            {
                return this.activeFieldSpecified;
            }
            set
            {
                this.activeFieldSpecified = value;
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


}
