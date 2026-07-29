---
name: Feature Request
about: >
    Commits que adicionam novas funcionalidades ou recursos ao projeto. Exemplo: página de perfil, modo escuro ou integração com uma nova API.
title: '[feat]:'
labels: ['feature']
assignees: []

---

## Resumo

Adicionar um botão de alternância para o modo escuro no menu de configurações, permitindo que os usuários alternem entre os temas claro e escuro.

## Motivação

Solicitado pelos usuários para melhorar a acessibilidade e o conforto visual em ambientes com pouca iluminação.

## Tarefas

- [ ] Criar componente de alternância
- [ ] Atualizar o contexto/estado do tema
- [ ] Armazenar a preferência no `localStorage`
- [ ] Adicionar estilos para o tema escuro
- [ ] Testar a lógica de alternância de tema

## Critérios de conclusão

O botão de alternância do modo escuro está visível nas configurações e mantém a preferência do usuário entre as sessões.