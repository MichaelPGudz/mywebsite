export function scrollToSection(sectionId) {
    const section = document.getElementById(sectionId);

    // Scroll smoothly to the section
    section.scrollIntoView({ behavior: 'smooth' });
}