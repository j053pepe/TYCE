﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.7.2053.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "https://www.siged.sep.gob.mx/titulos/", IsNullable = false)]
public partial class TituloElectronico
{

    private TituloElectronicoFirmaResponsable[] firmaResponsablesField;

    private TituloElectronicoInstitucion institucionField;

    private TituloElectronicoCarrera carreraField;

    private TituloElectronicoProfesionista profesionistaField;

    private TituloElectronicoExpedicion expedicionField;

    private TituloElectronicoAntecedente antecedenteField;

    private System.Xml.XmlElement autenticacionField;

    private string versionField;

    private string folioControlField;

    public TituloElectronico()
    {
        this.versionField = "1.0";
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("FirmaResponsable", IsNullable = false)]
    public TituloElectronicoFirmaResponsable[] FirmaResponsables
    {
        get
        {
            return this.firmaResponsablesField;
        }
        set
        {
            this.firmaResponsablesField = value;
        }
    }

    /// <remarks/>
    public TituloElectronicoInstitucion Institucion
    {
        get
        {
            return this.institucionField;
        }
        set
        {
            this.institucionField = value;
        }
    }

    /// <remarks/>
    public TituloElectronicoCarrera Carrera
    {
        get
        {
            return this.carreraField;
        }
        set
        {
            this.carreraField = value;
        }
    }

    /// <remarks/>
    public TituloElectronicoProfesionista Profesionista
    {
        get
        {
            return this.profesionistaField;
        }
        set
        {
            this.profesionistaField = value;
        }
    }

    /// <remarks/>
    public TituloElectronicoExpedicion Expedicion
    {
        get
        {
            return this.expedicionField;
        }
        set
        {
            this.expedicionField = value;
        }
    }

    /// <remarks/>
    public TituloElectronicoAntecedente Antecedente
    {
        get
        {
            return this.antecedenteField;
        }
        set
        {
            this.antecedenteField = value;
        }
    }

    /// <remarks/>
    public System.Xml.XmlElement Autenticacion
    {
        get
        {
            return this.autenticacionField;
        }
        set
        {
            this.autenticacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string version
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

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string folioControl
    {
        get
        {
            return this.folioControlField;
        }
        set
        {
            this.folioControlField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoFirmaResponsable
{
    private string nombreField;

    private string primerApellidoField;

    private string segundoApellidoField;

    private string curpField;

    private string idCargoField;

    private string cargoField;

    private string abrTituloField;

    private string selloField;

    private string certificadoResponsableField;

    private string noCertificadoResponsableField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string primerApellido
    {
        get
        {
            return this.primerApellidoField;
        }
        set
        {
            this.primerApellidoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string segundoApellido
    {
        get
        {
            return this.segundoApellidoField;
        }
        set
        {
            this.segundoApellidoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string curp
    {
        get
        {
            return this.curpField;
        }
        set
        {
            this.curpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string idCargo
    {
        get
        {
            return this.idCargoField;
        }
        set
        {
            this.idCargoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cargo
    {
        get
        {
            return this.cargoField;
        }
        set
        {
            this.cargoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string abrTitulo
    {
        get
        {
            return this.abrTituloField;
        }
        set
        {
            this.abrTituloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string sello
    {
        get
        {
            return this.selloField;
        }
        set
        {
            this.selloField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string certificadoResponsable
    {
        get
        {
            return this.certificadoResponsableField;
        }
        set
        {
            this.certificadoResponsableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noCertificadoResponsable
    {
        get
        {
            return this.noCertificadoResponsableField;
        }
        set
        {
            this.noCertificadoResponsableField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoInstitucion
{

    private string cveInstitucionField;

    private string nombreInstitucionField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cveInstitucion
    {
        get
        {
            return this.cveInstitucionField;
        }
        set
        {
            this.cveInstitucionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombreInstitucion
    {
        get
        {
            return this.nombreInstitucionField;
        }
        set
        {
            this.nombreInstitucionField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoCarrera
{

    private string cveCarreraField;

    private string nombreCarreraField;

    private string fechaInicioField;

    private string fechaTerminacionField;

    private string idAutorizacionReconocimientoField;

    private string autorizacionReconocimientoField;

    private string numeroRvoeField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string cveCarrera
    {
        get
        {
            return this.cveCarreraField;
        }
        set
        {
            this.cveCarreraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombreCarrera
    {
        get
        {
            return this.nombreCarreraField;
        }
        set
        {
            this.nombreCarreraField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaInicio
    {
        get
        {
            return this.fechaInicioField;
        }
        set
        {
            this.fechaInicioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaTerminacion
    {
        get
        {
            return this.fechaTerminacionField;
        }
        set
        {
            this.fechaTerminacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string idAutorizacionReconocimiento
    {
        get
        {
            return this.idAutorizacionReconocimientoField;
        }
        set
        {
            this.idAutorizacionReconocimientoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string autorizacionReconocimiento
    {
        get
        {
            return this.autorizacionReconocimientoField;
        }
        set
        {
            this.autorizacionReconocimientoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string numeroRvoe
    {
        get
        {
            return this.numeroRvoeField;
        }
        set
        {
            this.numeroRvoeField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoProfesionista
{

    private string curpField;

    private string nombreField;

    private string primerApellidoField;

    private string segundoApellidoField;

    private string correoElectronicoField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string curp
    {
        get
        {
            return this.curpField;
        }
        set
        {
            this.curpField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nombre
    {
        get
        {
            return this.nombreField;
        }
        set
        {
            this.nombreField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string primerApellido
    {
        get
        {
            return this.primerApellidoField;
        }
        set
        {
            this.primerApellidoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string segundoApellido
    {
        get
        {
            return this.segundoApellidoField;
        }
        set
        {
            this.segundoApellidoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string correoElectronico
    {
        get
        {
            return this.correoElectronicoField;
        }
        set
        {
            this.correoElectronicoField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoExpedicion
{

    private string fechaExpedicionField;

    private string idModalidadTitulacionField;

    private string modalidadTitulacionField;

    private string fechaExamenProfesionalField;

    private string fechaExencionExamenProfesionalField;

    private string cumplioServicioSocialField;

    private string idFundamentoLegalServicioSocialField;

    private string fundamentoLegalServicioSocialField;

    private string idEntidadFederativaField;

    private string entidadFederativaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaExpedicion
    {
        get
        {
            return this.fechaExpedicionField;
        }
        set
        {
            this.fechaExpedicionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string idModalidadTitulacion
    {
        get
        {
            return this.idModalidadTitulacionField;
        }
        set
        {
            this.idModalidadTitulacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string modalidadTitulacion
    {
        get
        {
            return this.modalidadTitulacionField;
        }
        set
        {
            this.modalidadTitulacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaExamenProfesional
    {
        get
        {
            return this.fechaExamenProfesionalField;
        }
        set
        {
            this.fechaExamenProfesionalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaExencionExamenProfesional
    {
        get
        {
            return this.fechaExencionExamenProfesionalField;
        }
        set
        {
            this.fechaExencionExamenProfesionalField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string cumplioServicioSocial
    {
        get
        {
            return this.cumplioServicioSocialField;
        }
        set
        {
            this.cumplioServicioSocialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string idFundamentoLegalServicioSocial
    {
        get
        {
            return this.idFundamentoLegalServicioSocialField;
        }
        set
        {
            this.idFundamentoLegalServicioSocialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fundamentoLegalServicioSocial
    {
        get
        {
            return this.fundamentoLegalServicioSocialField;
        }
        set
        {
            this.fundamentoLegalServicioSocialField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string idEntidadFederativa
    {
        get
        {
            return this.idEntidadFederativaField;
        }
        set
        {
            this.idEntidadFederativaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string entidadFederativa
    {
        get
        {
            return this.entidadFederativaField;
        }
        set
        {
            this.entidadFederativaField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.7.2053.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "https://www.siged.sep.gob.mx/titulos/")]
public partial class TituloElectronicoAntecedente
{

    private string institucionProcedenciaField;

    private string idTipoEstudioAntecedenteField;

    private string tipoEstudioAntecedenteField;

    private string idEntidadFederativaField;

    private string entidadFederativaField;

    private string fechaInicioField;

    private string fechaTerminacionField;

    private string noCedulaField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string institucionProcedencia
    {
        get
        {
            return this.institucionProcedenciaField;
        }
        set
        {
            this.institucionProcedenciaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string idTipoEstudioAntecedente
    {
        get
        {
            return this.idTipoEstudioAntecedenteField;
        }
        set
        {
            this.idTipoEstudioAntecedenteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string tipoEstudioAntecedente
    {
        get
        {
            return this.tipoEstudioAntecedenteField;
        }
        set
        {
            this.tipoEstudioAntecedenteField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string idEntidadFederativa
    {
        get
        {
            return this.idEntidadFederativaField;
        }
        set
        {
            this.idEntidadFederativaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string entidadFederativa
    {
        get
        {
            return this.entidadFederativaField;
        }
        set
        {
            this.entidadFederativaField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaInicio
    {
        get
        {
            return this.fechaInicioField;
        }
        set
        {
            this.fechaInicioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string fechaTerminacion
    {
        get
        {
            return this.fechaTerminacionField;
        }
        set
        {
            this.fechaTerminacionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string noCedula
    {
        get
        {
            return this.noCedulaField;
        }
        set
        {
            this.noCedulaField = value;
        }
    }
}
